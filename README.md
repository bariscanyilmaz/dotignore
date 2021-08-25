# dotignore

`dotignore` is a CLI tool for generating .gitignore files. 

# Usage

## Create .gitignore files

Create your dotignore files with init verb

```bash
dotignore init <template>
```
![dotignore-init-value](https://user-images.githubusercontent.com/30300440/130858831-46a7c287-fb65-4f46-b36b-b3c944c34775.gif)



Also, init is defeault verb and you can omit it

```bash
dotignore <template>
```
![dotignore-value](https://user-images.githubusercontent.com/30300440/130859272-db7445a8-5070-47a8-97b8-8bfb22280a35.gif)


## List available .gitignore templates

List your dotignore files with ls verb

```bash
dotignore ls 
```
![dotignore-ls](https://user-images.githubusercontent.com/30300440/130860981-5c912319-68df-4899-8bee-c66956131c13.gif)


Also, ls has -q or --query option for searching your template

```bash
dotignore ls -q <template>
```
![dotignore-ls-q](https://user-images.githubusercontent.com/30300440/130861005-4305ad55-5143-48af-8006-c0452dc82d84.gif)
