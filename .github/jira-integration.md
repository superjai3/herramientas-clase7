# 🔗 Integración GitHub + Jira

## Configuración del Proyecto

**Jira URL:** https://andresvaldes1001.atlassian.net
**Proyecto:** SCRUM
**Board:** https://andresvaldes1001.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog

## 📋 Configuración de Integración

### 1. Instalar GitHub for Jira App

1. Ve a: https://andresvaldes1001.atlassian.net/jira/settings/apps
2. Buscar "GitHub for Jira" en Atlassian Marketplace
3. Installar la aplicación
4. Conectar con el repositorio: `superjai3/herramientas-clase7`

### 2. Configurar Smart Commits

Los commits deben seguir este formato para automatizar Jira:

```bash
# Transicionar un issue
git commit -m "SCRUM-123 #time 2h #comment Implementada validación de clientes"

# Cerrar un issue
git commit -m "SCRUM-124 #close Corregido bug en cálculo de primas"

# Múltiples acciones
git commit -m "SCRUM-125 #time 1h #comment Refactoring terminado #resolve"
```

### 3. Comandos Smart Commit Disponibles

- `#time <value>` - Registrar tiempo trabajado
- `#comment <comment>` - Agregar comentario
- `#resolve` - Resolver issue
- `#close` - Cerrar issue
- `#reopen` - Reabrir issue

### 4. Convenciones de Branches

```bash
# Feature branch
git checkout -b feature/SCRUM-123-sistema-clientes

# Bugfix branch
git checkout -b bugfix/SCRUM-124-corregir-validacion

# Hotfix branch
git checkout -b hotfix/SCRUM-125-error-critico
```

## 🎯 Workflow Sugerido

### Development Flow
1. **Crear issue en Jira** → Asignar → Mover a "In Progress" 
2. **Crear branch** → `feature/SCRUM-XXX-descripcion`
3. **Hacer commits** → Con smart commits referenciando SCRUM-XXX
4. **Crear PR** → Template automáticamente incluirá link a Jira
5. **Review + Merge** → Jira se actualiza automáticamente

### Planning Flow
1. **Epic creation** → En Jira con prefix SCRUM-
2. **Story breakdown** → Cada historia referencia la epic
3. **Sprint planning** → Usar board de Jira
4. **Daily standups** → Basar en Jira board
5. **Retrospective** → Documentar insights en Jira

## 🔧 Configuración Adicional

### Branch Protection Rules (GitHub)
- Require PR reviews before merging
- Require status checks to pass
- Require branches to be up to date
- Include administrators

### Jira Automation Rules
- Auto-assign issues basado en componentes
- Mover issues cuando PR es creado
- Notificar en Slack/Teams cuando issue es completado

## 📊 Métricas y Reportes

### Jira Dashboards
- Velocity Chart
- Burndown Chart  
- Control Chart
- Cumulative Flow Diagram

### GitHub Insights
- Code frequency
- Contributors
- Pulse
- Network graph

## 🎯 Próximos Pasos

1. ✅ Instalar GitHub for Jira app
2. ✅ Crear épicas en Jira usando el backlog definido
3. ✅ Configurar branch protection rules
4. ✅ Entrenar al equipo en smart commits
5. ✅ Definir primer sprint
