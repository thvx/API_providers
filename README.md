# 🏢 Diligencia Proveedores API

API REST para la gestión de proveedores y cruce con listas de riesgo.

## 🚀 Tecnologías

- **Backend**: ASP.NET Core 9.0
- **Base de datos**: SQL Server
- **ORM**: Entity Framework Core
- **Autenticación**: JWT Bearer
- **Arquitectura**: Clean Architecture con MediatR
- **Servidor**: Kestrel

## 📋 Prerequisitos

- .NET 9.0 SDK
- SQL Server (LocalDB, Express, o completo)
- Visual Studio 2022 o VS Code

## ⚙️ Configuración

### 1. Clonar el repositorio
```bash
git clone https://github.com/tu-usuario/DiligenciaProveedores.git
cd DiligenciaProveedores
```

### 2. Configurar variables de entorno
```bash
# Copiar el template de variables de entorno
cp .env.template .env

# Editar .env con tus valores reales
# Asegúrate de cambiar:
# - La cadena de conexión a tu base de datos
# - La clave JWT por una segura
```

### 3. Restaurar paquetes
```bash
dotnet restore
```

### 4. Configurar base de datos
```bash
# Crear migraciones
dotnet ef migrations add InitialCreate

# Aplicar migraciones
dotnet ef database update
```

### 5. Ejecutar la aplicación
```bash
dotnet run
```

## 🔗 URLs

- **API**: http://localhost:5003
- **Swagger**: http://localhost:5003/swagger
- **HTTPS**: https://localhost:7220

## 🔐 Autenticación

La API usa JWT Bearer tokens. Para obtener un token:

```bash
POST /api/Auth/login
{
  "username": "admin",
  "password": "password123"
}
```

## 📚 Endpoints

### Proveedores
- `GET /api/Providers` - Obtener todos los proveedores
- `GET /api/Providers/{id}` - Obtener proveedor por ID
- `POST /api/Providers` - Crear nuevo proveedor
- `PUT /api/Providers/{id}` - Actualizar proveedor
- `DELETE /api/Providers/{id}` - Eliminar proveedor

### Autenticación
- `POST /api/Auth/login` - Iniciar sesión

## 🗂️ Estructura del proyecto

```
DiligenciaProveedores/
├── Application/           # Lógica de aplicación (DTOs, Commands, Queries)
├── Domain/               # Entidades y enums de dominio
├── Persistence/          # Contexto de base de datos y repositorios
├── Presentation/         # Controladores y extensiones
├── Properties/           # Configuración de launch
└── Scripts/             # Scripts SQL para seeding
```

## 🔧 Variables de entorno

Crea un archivo `.env` basado en `.env.template` con:

```env
# Base de datos
ConnectionStrings__DefaultConnection=Server=TU_SERVIDOR;Database=TU_DB;...

# JWT
Jwt__Key=TU_CLAVE_JWT_SECRETA_MINIMO_32_CARACTERES
Jwt__Issuer=DiligenciaProveedoresAPI
Jwt__Audience=DiligenciaProveedoresFrontend
```

## 📝 Notas de desarrollo

- El archivo `.env` contiene información sensible y NO debe subirse a git
- La key JWT debe tener mínimo 32 caracteres para HMAC-SHA256
- En producción, usa variables de entorno del sistema en lugar de archivos .env

## 🤝 Contribuir

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📄 Licencia

Este proyecto está licenciado bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
