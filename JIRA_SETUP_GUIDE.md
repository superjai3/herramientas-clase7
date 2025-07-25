# 🚀 Configuración Completa GitHub + Jira

## ✅ Paso a Paso para Configurar la Integración

### 1. 🔗 Instalar GitHub for Jira App

1. **Ir a Jira Admin:**
   - Visita: https://andresvaldes1001.atlassian.net/jira/settings/apps
   - Login con tu cuenta de Jira

2. **Buscar e instalar GitHub for Jira:**
   - Click en "Find new apps"
   - Buscar "GitHub for Jira"
   - Click "Install" en la app oficial de Atlassian

3. **Conectar el repositorio:**
   - Después de la instalación, ir a "GitHub Integration"
   - Click "Connect GitHub organization"
   - Autorizar acceso a `superjai3/herramientas-clase7`

### 2. 📋 Crear las Épicas en Jira

**Importar desde nuestro backlog:**

```
SCRUM-1: Sistema de Gestión de Clientes (21 SP)
SCRUM-2: Sistema de Pólizas (34 SP)  
SCRUM-3: Sistema de Cotizaciones (21 SP)
SCRUM-4: Sistema de Siniestros (28 SP)
SCRUM-5: Panel de Administración (18 SP)
SCRUM-6: Sistema de Pagos (25 SP)
```

**Para cada épica crear:**
1. Epic en Jira con código SCRUM-X
2. Desglosar en historias (SCRUM-X1, SCRUM-X2, etc.)
3. Estimar story points
4. Asignar a sprints

### 3. 🔐 Configurar Secrets en GitHub

**Ir a GitHub Settings:**
- https://github.com/superjai3/herramientas-clase7/settings/secrets/actions

**Agregar estos secrets:**
```
JIRA_BASE_URL = https://andresvaldes1001.atlassian.net
JIRA_USER_EMAIL = [tu email de Jira]
JIRA_API_TOKEN = [tu API token de Jira]
```

**Para obtener API Token:**
1. Ir a: https://id.atlassian.com/manage-profile/security/api-tokens  
2. Click "Create API token"
3. Dar nombre: "GitHub Integration"
4. Copiar el token generado

### 4. 🌿 Configurar Branch Protection

**En GitHub Settings > Branches:**
1. Click "Add rule" para branch `main`
2. Activar:
   - ✅ Require pull request reviews before merging
   - ✅ Require status checks to pass before merging
   - ✅ Require branches to be up to date before merging
   - ✅ Include administrators

### 5. 📝 Entrenar al Equipo en Smart Commits

**Formato de commits para Jira:**
```bash
# Trabajar en un issue
git commit -m "SCRUM-10 #time 2h Implementar validación de DNI"

# Completar un issue  
git commit -m "SCRUM-11 #resolve Registro de clientes empresas completado"

# Transicionar issue
git commit -m "SCRUM-12 #transition In Progress Iniciando desarrollo de consultas"
```

**Workflow de branches:**
```bash
# Crear branch para épica/historia
git checkout -b feature/SCRUM-10-validacion-clientes
git checkout -b bugfix/SCRUM-15-error-validacion
git checkout -b hotfix/SCRUM-20-error-critico
```

### 6. 🎯 Configurar el Primer Sprint

**En Jira Board:**
1. Ir al backlog: https://andresvaldes1001.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog
2. Crear nuevo sprint: "Sprint 1 - Sistema Clientes"
3. Arrastrar historias de SCRUM-1 al sprint
4. Estimar story points en planning poker
5. Iniciar sprint

**Historias sugeridas para Sprint 1:**
```
SCRUM-10: Registrar clientes personas físicas (5 SP)
SCRUM-11: Registrar clientes empresas (5 SP)  
SCRUM-12: Consultar información de clientes (3 SP)
SCRUM-13: Actualizar datos de clientes (3 SP)
SCRUM-14: Ver perfil de cliente (3 SP)

Total: 19 Story Points
```

### 7. 🔄 Workflow Diario Recomendado

**Daily Standup (usando Jira Board):**
1. ¿Qué hice ayer? → Ver tickets "Done"
2. ¿Qué haré hoy? → Ver tickets "In Progress"  
3. ¿Hay impedimentos? → Crear tickets de impedimento

**Durante desarrollo:**
1. Mover ticket a "In Progress" en Jira
2. Crear branch: `feature/SCRUM-XX-descripcion`
3. Hacer commits con smart commits
4. Crear PR (template incluye link a Jira automáticamente)
5. Después del merge, ticket se mueve a "Done" automáticamente

### 8. 📊 Configurar Dashboards y Reportes

**Dashboards recomendados en Jira:**
- Sprint Health Gadget
- Burndown Chart  
- Velocity Chart
- Created vs Resolved Issues

**Configurar notificaciones:**
- Slack/Teams notifications para issues completados
- Email notifications para blocked issues
- Automatic assignment based on components

### 9. 🎨 Personalizar el Board

**Columnas sugeridas:**
```
Backlog → To Do → In Progress → Code Review → Testing → Done
```

**Swimlanes:**
```
- Por Épica (SCRUM-1, SCRUM-2, etc.)
- Por Asignado  
- Por Prioridad
```

### 10. ✅ Verificar la Integración

**Tests a realizar:**
1. ✅ Crear commit con smart commit → Verificar comentario en Jira
2. ✅ Crear PR → Verificar link a Jira en descripción
3. ✅ Merge PR → Verificar transición automática en Jira
4. ✅ Build fail → Verificar comentario de error en Jira

---

## 🎉 ¡Listo para Colaborar!

Una vez completados estos pasos, tendrás:

- ✅ Integración automática GitHub ↔ Jira
- ✅ Smart commits funcionando
- ✅ CI/CD notifications en Jira  
- ✅ Branch protection configurado
- ✅ Templates para issues y PRs
- ✅ Workflow de desarrollo definido

## 🆘 Soporte

Si necesitas ayuda:
1. Documentación oficial: https://support.atlassian.com/jira-software-cloud/docs/integrate-with-github/
2. GitHub for Jira docs: https://github.com/atlassian/github-for-jira
3. Smart commits reference: https://support.atlassian.com/bitbucket-cloud/docs/use-smart-commits/
