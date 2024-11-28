git init //inicializar archivo, aparece archivo .git
git branch -M main  //cambia a la rama main
git config --global credential.username "user"  //cambia cuenta de git a la que se va a subir el repositorio
git config --global user.name ""  //usuario a la que se va a subir el archivo
git config --global user.email ""  //email de la cuenta del usuario
git add .  //guardar cambios del ultimo save del archivo
git commit -m ""  //commit
git push -u origin main  //primer push (push del archivo original)

git branch  //enumera todas las ramas
git branch -a  //enumera todas las ramas con control remoto
git branch nueva_rama  //crea una nueva rama
git branch -d rama  //elimina rama si no estas en esa rama

git checkout rama  //cambia a la rama escrita
git checkout -b nueva_rama  //crear una nueva rama y cambiar a esta

git merge rama  //fusiona la rama actual con la escrita

git push  //push normal
git push --set-upstream origin main  //otro push origin