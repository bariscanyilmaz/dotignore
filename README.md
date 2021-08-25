# dotignore

`dotignore` is a CLI tool for generating .gitignore files. 

# Usage

## Create .gitignore files

Create your dotignore files with init verb

```bash
dotignore init <template>
```

Also, init is defeault verb and you can omit it

```bash
dotignore <template>
```

## List available .gitignore templates

List your dotignore files with ls verb

```bash
dotignore ls 
```

Also, ls has -q or --query option for searching your template

```bash
dotignore ls -q <template>
```