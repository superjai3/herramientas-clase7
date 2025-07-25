# Configuración GitHub + Jira para SeguroqueSí

## 🎯 Guía de Setup Completa

### 1. Configuración de Jira

#### Crear cuenta Jira:
1. Ve a: https://www.atlassian.com/software/jira
2. Crear cuenta gratuita (hasta 10 usuarios)
3. Selecciona el template "Software development"

#### Configuración inicial del proyecto:
- **Nombre del proyecto**: SeguroqueSí
- **Clave del proyecto**: SEG
- **Tipo de proyecto**: Software development
- **Template**: Kanban o Scrum (recomendado: Scrum)

### 2. Estructura de Issues en Jira

#### Tipos de Issues:
- **Epic**: Funcionalidades grandes (ej: "Sistema de Pólizas")
- **Story**: Historias de usuario (ej: "Como cliente quiero crear una póliza")
- **Task**: Tareas técnicas (ej: "Configurar base de datos")
- **Bug**: Errores encontrados
- **Sub-task**: Tareas pequeñas dentro de una Story

#### Ejemplos de Épicas para tu proyecto:
1. **SEG-1**: Sistema de Gestión de Clientes
2. **SEG-2**: Sistema de Pólizas
3. **SEG-3**: Sistema de Cotizaciones
4. **SEG-4**: Sistema de Siniestros
5. **SEG-5**: Panel de Administración
6. **SEG-6**: Sistema de Pagos

### 3. Integración GitHub + Jira

#### Instalar GitHub for Jira:
1. En Jira, ve a "Apps" → "Find new apps"
2. Busca "GitHub for Jira" de Atlassian
3. Instalar (gratuito)
4. Configurar con tu repositorio: `superjai3/herramientas-clase7`

#### Configurar Webhooks:
- Permite sincronización automática entre GitHub y Jira
- Los commits, PRs y deployments aparecen en Jira
- Los issues de Jira se vinculan automáticamente

### 4. Workflow de Desarrollo

#### Convención de Branches:
```
feature/SEG-123-agregar-validacion-polizas
bugfix/SEG-456-corregir-calculo-prima
hotfix/SEG-789-error-login-critico
```

#### Convención de Commits:
```
git commit -m "SEG-123: feat: agregar validación de pólizas

- Implementar validación de datos obligatorios
- Agregar mensajes de error personalizados
- Tests unitarios para validaciones"
```

#### Estados en Jira:
1. **To Do**: Por hacer
2. **In Progress**: En desarrollo
3. **Code Review**: En revisión
4. **Testing**: En pruebas
5. **Done**: Completado

### 5. Automatizaciones

#### Smart Commits (automático con la integración):
- `SEG-123 #comment "Agregué validación"` → Añade comentario
- `SEG-123 #transition "In Progress"` → Cambia estado
- `SEG-123 #assign jaime` → Asigna issue

#### GitHub Actions que notifican a Jira:
- Build exitoso/fallido
- Deploy a staging/producción
- Cobertura de tests

### 6. Reportes y Métricas

#### En Jira:
- Burndown charts
- Velocity tracking
- Time tracking
- Sprint reports

#### En GitHub:
- Code review metrics
- Deployment frequency
- Lead time for changes

## 📋 Plantillas de Issues

### Epic Template:
```
**Descripción**
[Descripción de la funcionalidad completa]

**Objetivos**
- [ ] Objetivo 1
- [ ] Objetivo 2

**Criterios de Aceptación**
- [ ] Criterio 1
- [ ] Criterio 2

**Historias de Usuario Relacionadas**
- SEG-XXX
- SEG-YYY
```

### Story Template:
```
**Como** [tipo de usuario]
**Quiero** [funcionalidad]
**Para** [beneficio/razón]

**Criterios de Aceptación**
- [ ] Dado que...
- [ ] Cuando...
- [ ] Entonces...

**Tareas Técnicas**
- [ ] Tarea 1
- [ ] Tarea 2

**Definition of Done**
- [ ] Código implementado
- [ ] Tests escritos y pasando
- [ ] Code review completado
- [ ] Documentación actualizada
```

## 🚀 Próximos Pasos

1. **Crear cuenta Jira**
2. **Configurar proyecto**
3. **Instalar GitHub for Jira**
4. **Crear primeras épicas**
5. **Definir primer sprint**

## 📞 Soporte

Para dudas sobre la configuración:
- Documentación Jira: https://support.atlassian.com/jira-software-cloud/
- GitHub for Jira: https://github.com/integrations/jira
