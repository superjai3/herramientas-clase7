# GitHub + Jira Integration

## 🔗 Links de Integración

### Jira Project
- **URL**: [Tu URL de Jira aquí una vez creado el proyecto]
- **Project Key**: SEG
- **Project Name**: SeguroqueSí

### GitHub Repository
- **URL**: https://github.com/superjai3/herramientas-clase7
- **Branch Protection**: main branch protected
- **Required Reviews**: 1 reviewer minimum

## 🤖 Automation Rules

### Smart Commits
Usa estos formatos en tus commits para automatizar Jira:

```bash
# Transicionar issue a "In Progress"
git commit -m "SEG-123 #transition 'In Progress' Implementing user validation"

# Agregar comentario al issue
git commit -m "SEG-123 #comment 'Added password encryption logic'"

# Asignar issue
git commit -m "SEG-123 #assign jaime Added login functionality"

# Registrar tiempo trabajado
git commit -m "SEG-123 #time '2h 30m' Completed user authentication"

# Combinar múltiples acciones
git commit -m "SEG-123 #transition 'Done' #time '1h' #comment 'Feature completed and tested'"
```

### Branch Naming Convention
```bash
# Features
feature/SEG-123-user-authentication
feature/SEG-124-password-reset

# Bug fixes
bugfix/SEG-125-login-error
bugfix/SEG-126-validation-issue

# Hotfixes
hotfix/SEG-127-critical-security-fix

# Technical tasks
tech/SEG-128-database-migration
tech/SEG-129-code-refactoring
```

## 📊 Jira Board Setup

### Columns (Kanban/Scrum)
1. **Backlog** - Issues pendientes
2. **Selected for Development** - Sprint actual
3. **In Progress** - En desarrollo
4. **Code Review** - En revisión
5. **Testing** - En pruebas
6. **Done** - Completado

### Issue Types Configuration
- **Epic** (🎯): Funcionalidades grandes
- **Story** (📖): Historias de usuario
- **Task** (⚡): Tareas técnicas
- **Bug** (🐛): Errores
- **Sub-task** (📝): Subtareas

## 🔄 Workflow States

### Story/Task Workflow
```
To Do → In Progress → Code Review → Testing → Done
```

### Bug Workflow
```
Open → In Progress → Fixed → Verified → Closed
```

## 📈 Reports & Metrics

### Jira Reports to Track
- **Burndown Chart**: Progreso del sprint
- **Velocity Chart**: Velocidad del equipo
- **Control Chart**: Tiempo de ciclo
- **Cumulative Flow**: Flujo de trabajo

### GitHub Metrics
- **Pull Request metrics**: Tiempo de revisión
- **Code review coverage**: % de código revisado
- **Deployment frequency**: Frecuencia de releases
- **Lead time**: Tiempo desde desarrollo a producción

## 🎯 Sprint Planning Template

### Sprint Goal
```
Sprint X Goal: [Objetivo principal del sprint]

Duration: 2 weeks
Start Date: [Fecha inicio]
End Date: [Fecha fin]

Capacity: [Story points o horas disponibles]
Commitment: [Story points o horas comprometidas]
```

### Definition of Ready (DoR)
- [ ] Historia de usuario clara y entendible
- [ ] Criterios de aceptación definidos
- [ ] Estimación completada
- [ ] Dependencias identificadas
- [ ] Mockups/wireframes (si aplica)

### Definition of Done (DoD)
- [ ] Código implementado y funcional
- [ ] Tests unitarios escritos y pasando
- [ ] Code review completado y aprobado
- [ ] Documentación actualizada
- [ ] Deploy en ambiente de testing
- [ ] Criterios de aceptación verificados
- [ ] Issue marcado como "Done" en Jira

## 🚀 Release Process

### Pre-release Checklist
- [ ] Todos los issues del milestone completados
- [ ] Tests de regresión ejecutados
- [ ] Documentación actualizada
- [ ] Release notes preparadas
- [ ] Deploy en staging validado

### Release Notes Template
```markdown
# Release v1.X.X - [Fecha]

## 🚀 New Features
- SEG-123: [Descripción de la feature]

## 🐛 Bug Fixes
- SEG-124: [Descripción del fix]

## 🔧 Technical Improvements
- SEG-125: [Mejora técnica]

## 📖 Documentation
- Updated README.md
- Added API documentation

## 🔗 Links
- [Jira Release](link-to-jira-version)
- [GitHub Milestone](link-to-github-milestone)
```
