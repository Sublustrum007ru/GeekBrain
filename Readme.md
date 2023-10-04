# Базовые команды терминала

**cd <имя папки>** - Переместиться внутрь папки. Имя может быть любым.

**cd ..** - Переместиться из папки.

**mkdir** - Создать новую папку.

**ls** - Отобразить список папок и файлов.

**new-item "<имя файла>"** - Создать новый файл. Имя может быть любым.

# Команды GIT

**git init** - Инициализация локального репозитория.

**git status** - Отобразить текущее состояние git.

**git add <имя файла>** - Подготавливает файл к следующему коммиту.

**git add .** - Подготавливает все файлы к следующему коммиту.

**git reset <имя файла>** - Удаляет файл из подготовленных к коммиту.

**git reset .** - Удаляет все файлы из подготовленных к коммиту.

**git commit -m "message"** - Создание коммита.  

* **commit** - Зафиксированный набор изменений, который показывает, какие файлы изменились и что в них изменилось. 
* **-m** - флаг задающий сообщение коммита. Оно нужно, чтобы описать изменение, которые делает этот коммит.
* **message** - Текст сообщения, описывающее какое было изменение.

**git commit --amend -m "message"** - Отредактировать последнее сообзщение коммита

**git log** - Вывод на экран истории всех коммитов с их хеш-кодами.

**git branch** - Отображает список всех веток в репозитории.

**git branch <имя ветки>** - Создать новую ветку коммитов. Имя может быть любым.

**git checkout <имя ветки>** - Переход к другой ветке.

**git checkout -b <имя ветки>** - Создание и сразу переход в новую ветку. Имя может быть любым.

**git branch -d <имя ветки>** - Удалить ветку. 
* **-d** - флаг позволит удалить только слитую ветку. Когда из той ветки все данный слиты в ветку мастер.
* **-D** - фалг позволит удалить любую ветку, даже ту которая не слита. (не рекомендую ее использовать).

**git merge <имя ветки>** - Слить в текущую ветку изменения из <имя ветки>.

Тут в будущем будет больше команд для работы.