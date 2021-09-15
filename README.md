# dotignore

`dotignore` is a CLI tool for generating .gitignore files.

## Installation

### Linux

```sh
wget https://github.com/bariscanyilmaz/dotignore/releases/download/[version]/dotignore-[version]-linux-x64.tar.gz

sudo mkdir -p /usr/local/dotignore && sudo tar -C /usr/local/dotignore -xzf dotignore-[version]-linux-x64.tar.gz

export PATH=$PATH:/usr/local/dotignore
```

## Usage

### Create .gitignore files

Create your dotignore files with init verb

```bash
dotignore init <template>
```

![dotignore-init-value](https://user-images.githubusercontent.com/30300440/130862256-998b5e65-8f01-4e98-8e60-a729f30ff91e.gif)  

Also, init is defeault verb and you can omit it

```bash
dotignore <template>
```

![dotignore-value](https://user-images.githubusercontent.com/30300440/130862290-a9182421-0168-4d8e-a697-a7c5be2ac1a9.gif)  

### List available .gitignore templates

List your dotignore files with ls verb

```bash
dotignore ls 
```

![dotignore-ls](https://user-images.githubusercontent.com/30300440/130862328-38127d04-3aa1-45bd-a4d0-2117dc1fef18.gif)  

Also, ls has -q or --query option for searching your template

```bash
dotignore ls -q <template>
```

![dotignore-ls-q](https://user-images.githubusercontent.com/30300440/130862991-42fe1177-9bff-41e6-b85b-138be7a412c9.gif)
