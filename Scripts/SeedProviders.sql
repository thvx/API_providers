USE db_diligency;

INSERT INTO Providers (
    Id, 
    BusinessName, 
    TradeName, 
    TaxId, 
    PhoneNumber, 
    Email, 
    Website, 
    Address, 
    Country, 
    AnnualBillingUSD, 
    LastModified
)
VALUES 
(NEWID(), 'Microsoft Corporation', 'Microsoft', '12345678902', '+1-425-882-8080', 'info@microsoft.com', 'https://www.microsoft.com', 'One Microsoft Way, Redmond, WA', 'Estados Unidos', 2000000000.00, GETUTCDATE()),
(NEWID(), 'Amazon Web Services, Inc.', 'AWS', '12345678903', '+1-888-280-4331', 'support@aws.amazon.com', 'https://aws.amazon.com', '410 Terry Ave N, Seattle, WA', 'Estados Unidos', 1000000000.00, GETUTCDATE()),
(NEWID(), 'Alphabet Inc.', 'Google', '12345678904', '+1-650-253-0000', 'contact@google.com', 'https://www.google.com', '1600 Amphitheatre Parkway, Mountain View, CA', 'Estados Unidos', 1800000000.00, GETUTCDATE()),
(NEWID(), 'Apple Inc.', 'Apple', '12345678905', '+1-800-275-2273', 'contact@apple.com', 'https://www.apple.com', 'One Apple Park Way, Cupertino, CA', 'Estados Unidos', 2100000000.00, GETUTCDATE()),
(NEWID(), 'SAP SE', 'SAP', '12345678906', '+49-6227-747474', 'info@sap.com', 'https://www.sap.com', 'Dietmar-Hopp-Allee 16, Walldorf', 'Alemania', 120000000.00, GETUTCDATE()),
(NEWID(), 'Oracle Corporation', 'Oracle', '12345678907', '+1-650-506-7000', 'contact@oracle.com', 'https://www.oracle.com', '500 Oracle Parkway, Redwood Shores, CA', 'Estados Unidos', 400000000.00, GETUTCDATE()),
(NEWID(), 'Accenture PLC', 'Accenture', '12345678908', '+1-312-693-0161', 'info@accenture.com', 'https://www.accenture.com', '161 N Clark St, Chicago, IL', 'Estados Unidos', 500000000.00, GETUTCDATE()),
(NEWID(), 'Tata Consultancy Services', 'TCS', '12345678909', '+91-22-6778-9999', 'contact@tcs.com', 'https://www.tcs.com', 'TCS House, Mumbai', 'India', 300000000.00, GETUTCDATE()),
(NEWID(), 'Infosys Limited', 'Infosys', '12345678910', '+91-80-2852-0261', 'info@infosys.com', 'https://www.infosys.com', 'Electronics City, Bangalore', 'India', 270000000.00, GETUTCDATE()),
(NEWID(), 'Softtek S.A. de C.V.', 'Softtek', '12345678911', '+52-81-8158-8500', 'contact@softtek.com', 'https://www.softtek.com', 'Av. Eugenio Garza Sada 427, Monterrey', 'Mexico', 100000000.00, GETUTCDATE()),
(NEWID(), 'Mercado Libre S.R.L.', 'MercadoLibre', '12345678912', '+54-11-4640-8000', 'contact@mercadolibre.com', 'https://www.mercadolibre.com', 'Av. Caseros 3039, Buenos Aires', 'Argentina', 80000000.00, GETUTCDATE()),
(NEWID(), 'Globant S.A.', 'Globant', '12345678913', '+54-11-5556-7600', 'info@globant.com', 'https://www.globant.com', 'Ing. Butty 240, Buenos Aires', 'Argentina', 95000000.00, GETUTCDATE()),
(NEWID(), 'Claro Colombia S.A.', 'Claro', '12345678914', '+57-1-7488888', 'contacto@claro.com.co', 'https://www.claro.com.co', 'Cra 68a No. 24B-10, Bogotá', 'Colombia', 120000000.00, GETUTCDATE()),
(NEWID(), 'Telefónica Movistar S.A.', 'Movistar', '12345678915', '+34-911-33-3333', 'info@telefonica.com', 'https://www.telefonica.com', 'Gran Vía, 28, Madrid', 'España', 220000000.00, GETUTCDATE()),
(NEWID(), 'Banco Santander S.A.', 'Santander', '12345678916', '+34-912-737-000', 'contacto@santander.com', 'https://www.bancosantander.es', 'Av. de Cantabria s/n, Boadilla del Monte', 'España', 900000000.00, GETUTCDATE()),
(NEWID(), 'BBVA S.A.', 'BBVA', '12345678917', '+34-902-22-44-66', 'info@bbva.com', 'https://www.bbva.com', 'Plaza de San Nicolás, 4, Bilbao', 'España', 850000000.00, GETUTCDATE()),
(NEWID(), 'Petrobras S.A.', 'Petrobras', '12345678918', '+55-21-3224-4466', 'contato@petrobras.com.br', 'https://www.petrobras.com.br', 'Av. República do Chile, 65, Rio de Janeiro', 'Brasil', 780000000.00, GETUTCDATE()),
(NEWID(), 'Vale S.A.', 'Vale', '12345678919', '+55-31-3201-1836', 'info@vale.com', 'https://www.vale.com', 'Praia de Botafogo, 186, Rio de Janeiro', 'Brasil', 650000000.00, GETUTCDATE()),
(NEWID(), 'Grupo Bimbo S.A.B. de C.V.', 'Bimbo', '12345678920', '+52-55-5268-6600', 'contacto@grupobimbo.com', 'https://www.grupobimbo.com', 'Prolongación Paseo de la Reforma 1000, CDMX', 'Mexico', 470000000.00, GETUTCDATE()),
(NEWID(), 'Cemex S.A.B. de C.V.', 'Cemex', '12345678921', '+52-81-8888-8888', 'info@cemex.com', 'https://www.cemex.com', 'Av. Ricardo Margáin Zozaya 325, San Pedro', 'Mexico', 520000000.00, GETUTCDATE());
