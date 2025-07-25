# SeguroqueSí - Sistema de Gestión de Seguros

![.NET](https://img.shields.io/badge/.NET-9.0-blue)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-green)
![SQLite](https://img.shields.io/badge/Database-SQLite-lightblue)

## Descripción

SeguroqueSí es una aplicación web desarrollada en ASP.NET Core para la gestión integral de seguros. Permite manejar clientes, pólizas, cotizaciones, siniestros y más funcionalidades relacionadas con el negocio asegurador.

## Características

- ✅ Gestión de clientes y tomadores
- ✅ Creación y administración de pólizas
- ✅ Sistema de cotizaciones
- ✅ Gestión de siniestros
- ✅ Múltiples tipos de cobertura
- ✅ Sistema de pagos
- ✅ Gestión de contactos
- ✅ Panel de administración

## Tecnologías Utilizadas

- **Framework**: ASP.NET Core 9.0
- **ORM**: Entity Framework Core 9.0
- **Base de Datos**: SQLite (desarrollo) / SQL Server (producción)
- **Arquitectura**: MVC (Model-View-Controller)
- **UI**: Razor Views con Bootstrap

## Estructura del Proyecto

```
Seguroquesi/
├── Controllers/          # Controladores MVC
├── Models/              # Modelos de datos
├── Views/               # Vistas Razor
├── ViewModels/          # ViewModels
├── Data/                # Contexto de Entity Framework
├── Enums/               # Enumeraciones del sistema
├── Helpers/             # Clases auxiliares
├── Migrations/          # Migraciones de base de datos
└── wwwroot/            # Archivos estáticos (CSS, JS, imágenes)
```

## Instalación y Configuración

### Prerrequisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/[tu-usuario]/seguroquesi.git
   cd seguroquesi
   ```

2. **Restaurar dependencias**
   ```bash
   dotnet restore
   ```

3. **Aplicar migraciones**
   ```bash
   dotnet ef database update
   ```

4. **Ejecutar la aplicación**
   ```bash
   dotnet run
   ```

5. **Abrir en el navegador**
   ```
   https://localhost:5001
   ```

## Configuración de Base de Datos

### SQLite (Desarrollo)
La aplicación usa SQLite por defecto para desarrollo. La base de datos se crea automáticamente en `Seguroquesi.db`.

### SQL Server (Producción)
Para producción, actualiza la cadena de conexión en `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=tu-servidor;Database=SeguroqueSi;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

## Contribución

### Workflow de Desarrollo

1. **Fork del repositorio**
2. **Crear una rama para tu feature**
   ```bash
   git checkout -b feature/nueva-funcionalidad
   ```
3. **Realizar commits descriptivos**
   ```bash
   git commit -m "feat: agregar validación de pólizas"
   ```
4. **Push a tu rama**
   ```bash
   git push origin feature/nueva-funcionalidad
   ```
5. **Crear Pull Request**

### Convenciones de Código

- Usar PascalCase para clases, métodos y propiedades
- Usar camelCase para variables locales
- Comentar código complejo
- Seguir principios SOLID
- Escribir tests unitarios cuando sea posible

### Tipos de Commits

- `feat:` Nueva funcionalidad
- `fix:` Corrección de bugs
- `docs:` Documentación
- `style:` Cambios de formato
- `refactor:` Refactorización
- `test:` Tests
- `chore:` Tareas de mantenimiento

## Modelos Principales

### Cliente
Gestión de información de clientes (personas físicas y jurídicas).

### Póliza
Contratos de seguro con sus condiciones y coberturas.

### Cotización
Presupuestos y cotizaciones para potenciales clientes.

### Siniestro
Gestión de reclamos y siniestros.

## Estados y Enumeraciones

El sistema maneja diversos estados a través de enumeraciones:

- **EstadoPoliza**: Activa, Vencida, Cancelada, Suspendida
- **RolUsuario**: Admin, Cliente, Aseguradora, ProductorSeguro
- **TipoDocumento**: DNI, CUIT, Pasaporte, etc.
- **MetodoPago**: Efectivo, Tarjeta, Transferencia, etc.

## API Endpoints

### Principales Controladores

- `/Home` - Página principal
- `/Poliza` - Gestión de pólizas
- `/Cliente` - Gestión de clientes
- `/Cotizacion` - Sistema de cotizaciones
- `/Contacto` - Formulario de contacto
- `/Productos` - Catálogo de productos
- `/Ayuda` - Centro de ayuda

## Despliegue

### Desarrollo Local
```bash
dotnet run --environment Development
```

### Producción
```bash
dotnet publish -c Release -o ./publish
```

## Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo [LICENSE](LICENSE) para más detalles.

## Contacto

- **Proyecto**: SeguroqueSí
- **Institución**: ISTEA
- **Curso**: Herramientas de Programación

---

## Roadmap

- [ ] Implementar autenticación y autorización
- [ ] Agregar dashboard con reportes
- [ ] Integración con APIs de aseguradoras
- [ ] Sistema de notificaciones
- [ ] App móvil
- [ ] Tests automatizados
- [ ] CI/CD pipeline
