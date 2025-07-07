# 🏢 Diligencia Proveedores API

## 📖 Descripción general

API REST desarrollada para la gestión integral de proveedores. Esta aplicación permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre proveedores empresariales, manteniendo un registro de información corporativa y financiera.

### Características principales:
- ✅ **Gestión completa de proveedores** con información detallada
- ✅ **Autenticación y autorización** mediante JWT Bearer tokens
- ✅ **Documentación automática** con Swagger/OpenAPI
- ✅ **Base de datos** con Entity Framework Core
- ✅ **Validación de datos** y manejo de errores

### Casos de uso:
- Registro y mantenimiento de información de proveedores
- Consulta de datos empresariales y financieros
- Validación de identidad fiscal y datos corporativos
- Gestión de roles y permisos de usuario

## 🚀 Tecnologías empleadas

| Categoría | Tecnología | Versión | Descripción |
|-----------|------------|---------|-------------|
| **Framework** | ASP.NET Core | 9.0 | Framework web multiplataforma |
| **Lenguaje** | C# | 12.0 | Lenguaje de programación principal |
| **Base de datos** | SQL Server | 2019+ | Sistema de gestión de base de datos |
| **ORM** | Entity Framework Core | 9.0 | Mapeo objeto-relacional |
| **Autenticación** | JWT Bearer | - | Tokens de autenticación |
| **Mapeo** | AutoMapper | 15.0 | Mapeo entre objetos |
| **Documentación** | Swagger/OpenAPI | 9.0 | Documentación automática de API |
| **Servidor** | Kestrel | - | Servidor web de alto rendimiento |

### Dependencias principales:
```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.6" />
<PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="9.0.6" />
<PackageReference Include="MediatR" Version="13.0.0" />
<PackageReference Include="AutoMapper" Version="15.0.0" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="9.0.1" />
```

## 📚 Tabla de Endpoints

### 🔐 Autenticación

| Método | Endpoint | Descripción | Autenticación | Roles |
|--------|----------|-------------|---------------|-------|
| `POST` | `/api/Auth/login` | Iniciar sesión y obtener token JWT | ❌ No requerida | - |

**Ejemplo de request:**
```json
{
  "username": "admin",
  "password": "password123"
}
```

**Ejemplo de response:**
```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "expiration": "2025-07-07T15:30:00Z"
}
```

### 🏢 Gestión de Proveedores

| Método | Endpoint | Descripción | Autenticación | Roles |
|--------|----------|-------------|---------------|-------|
| `GET` | `/api/Providers` | Obtener lista de todos los proveedores | ✅ JWT Required | User, Admin |
| `GET` | `/api/Providers/{id}` | Obtener proveedor por ID específico | ✅ JWT Required | User, Admin |
| `POST` | `/api/Providers` | Crear un nuevo proveedor | ✅ JWT Required | User, Admin |
| `PUT` | `/api/Providers/{id}` | Actualizar proveedor existente | ✅ JWT Required | User, Admin |
| `DELETE` | `/api/Providers/{id}` | Eliminar proveedor | ✅ JWT Required | Admin |

#### Modelo de datos - Proveedor:

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "businessName": "Tecnología Avanzada S.A.",
  "tradeName": "TechAvanzada",
  "taxId": "12345678901",
  "phoneNumber": "+1-555-123-4567",
  "email": "contacto@techavanzada.com",
  "website": "https://www.techavanzada.com",
  "address": "Av. Innovación 123, Sector Tecnológico",
  "country": "Mexico",
  "annualBillingUSD": 2500000.00,
  "lastModified": "2025-07-07T10:30:00Z"
}
```

## ⚙️ Configuración para despliegue local

### 📋 Prerequisitos

Antes de comenzar, asegúrate de tener instalado:

- **.NET 9.0 SDK**
- **SQL Server 2019** o superior (LocalDB, Express, Developer, o Standard)

### 📁 Paso 1: Clonar y preparar el proyecto

```bash
# Clonar el repositorio
git clone https://github.com/thvx/API_providers.git

# Restaurar dependencias de NuGet
dotnet restore

# Verificar que compila correctamente
dotnet build
```

### 🗄️ Paso 2: Configurar SQL Server

```bash
# Verificar que el servicio está ejecutándose
net start mssqlserver

# Verificar conexión
sqlcmd -S localhost -E -Q "SELECT @@SERVERNAME"
```

### 🔐 Paso 3: Configurar variables de entorno

```bash
# Copiar plantilla de configuración
copy .env.template .env

# Editar archivo .env con valores reales
notepad .env
```

**Contenido del archivo `.env`:**

```env
# Base de datos - LocalDB
ConnectionStrings__DefaultConnection=Server=(localdb)\MSSQLLocalDB;Database=db_diligency;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true;

# Base de datos - SQL Server completo (alternativa)
# ConnectionStrings__DefaultConnection=Server=localhost;Database=db_diligency;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true;

# Base de datos - Con autenticación SQL (alternativa)
# ConnectionStrings__DefaultConnection=Server=localhost;Database=db_diligency;User Id=tu_usuario;Password=tu_password;TrustServerCertificate=true;MultipleActiveResultSets=true;

# JWT Configuration
Jwt__Key=CLAVE_SECRETA_MINIMO_32_CARACTERES_PARA_SEGURIDAD
Jwt__Issuer=DiligenciaProveedoresAPI
Jwt__Audience=DiligenciaProveedoresFrontend

# Entorno
ASPNETCORE_ENVIRONMENT=Development
```

### 🏗️ Paso 5: Configurar Entity Framework y base de datos

```bash
# Instalar herramientas de Entity Framework (si no están instaladas)
dotnet tool install --global dotnet-ef

# Verificar instalación
dotnet ef --version

# Crear migración inicial
dotnet ef migrations add InitialCreate

# Crear base de datos y aplicar migraciones
dotnet ef database update

# Verificar que se creó la base de datos
sqlcmd -S "(localdb)\MSSQLLocalDB" -E -Q "SELECT name FROM sys.databases WHERE name = 'db_diligency'"
```

### 🚀 Paso 6: Ejecutar la aplicación

```bash
# Ejecutar en modo desarrollo
dotnet run

```

**La aplicación estará disponible en:**
- **HTTP**: http://localhost:5003
- **HTTPS**: https://localhost:7220
- **Swagger**: http://localhost:5003/swagger

### ✅ Paso 7: Verificar funcionamiento

#### A. Verificar Swagger
1. Abrir navegador en: http://localhost:5003/swagger
2. Deberías ver la documentación de la API

#### B. Probar autenticación
```bash
curl -X POST "http://localhost:5003/api/Auth/login" \
  -H "Content-Type: application/json" \
  -d "{\"username\":\"admin\",\"password\":\"password123\"}"
```

#### C. Probar endpoints de proveedores
```bash
# Usar el token obtenido del paso anterior
curl -X GET "http://localhost:5003/api/Providers" \
  -H "Authorization: Bearer TU_TOKEN_JWT_AQUI"
```

### 📝 Estructura de archivos del proyecto

```
DiligenciaProveedores/
├── 📁 Application/              # Lógica de aplicación
│   ├── 📁 DTOs/                # Objetos de transferencia de datos
│   ├── 📁 Providers/
│   │   ├── 📁 Commands/        # Comandos (Create, Update, Delete)
│   │   ├── 📁 Queries/         # Consultas (GetAll, GetById)
│   │   └── 📁 Handlers/        # Manejadores de MediatR
├── 📁 Domain/                   # Entidades de dominio
│   ├── 📁 Entities/            # Entidades principales
│   ├── 📁 Enums/               # Enumeraciones
│   └── 📁 Interfaces/          # Contratos/Interfaces
├── 📁 Persistence/              # Acceso a datos
│   ├── 📁 Contexts/            # DbContext de Entity Framework
│   ├── 📁 Configurations/      # Configuración de entidades
│   ├── 📁 Migrations/          # Migraciones de base de datos
│   └── 📁 Repositories/        # Implementación de repositorios
├── 📁 Presentation/             # Capa de presentación
│   ├── 📁 Controllers/         # Controladores de API
│   ├── 📁 Extensions/          # Extensiones de configuración
│   └── 📁 Middlewares/         # Middlewares personalizados
├── 📁 Properties/               # Configuración de launch
├── 📁 Scripts/                  # Script SQL para cargar datos iniciales
├── 📄 appsettings.json         # Configuración de aplicación
├── 📄 .env.template            # Plantilla de variables de entorno
├── 📄 .gitignore               # Archivos ignorados por Git
└── 📄 README.md                # Este archivo
```
