# 🛠 ProductionRequestManager

> Приложение для учёта производственных заявок  
> Разработано на C# / WinForms с использованием SQLite и установочного инсталлятора

---

## 🔍 Описание

ProductionRequestManager — это настольное приложение, позволяющее создавать, редактировать, фильтровать и хранить производственные заявки.  
Приложение предназначено для использования в малых производственных или сервисных компаниях.

---

## 🎯 Возможности

- 📄 Добавление и редактирование заявок
- 🔎 Поиск по клиенту или описанию
- 🧭 Фильтрация по статусу (Новая, В работе, Завершена)
- 🧱 Хранение данных в **SQLite**
- 📤 Экспорт в **XML**
- 📦 Сборка установщика через **Inno Setup**
- 💾 Локальное хранение `requests.db` (создаётся автоматически)

---

## 🧰 Используемые технологии

| Язык       | Платформа            | База данных | Установщик     |
|------------|----------------------|-------------|----------------|
| C#         | .NET Framework 4.8   | SQLite      | Inno Setup     |
| WinForms   | Windows Desktop GUI  | System.Data.SQLite | 🖥 Windows-only |

---

## ⚙️ Установка и запуск

1. Установите [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) (если не установлен)
2. Скачайте и запустите `ProductionRequestManagerInstaller.exe` из [релизов](https://github.com/FlackJack1/ProductionRequestManager/releases)
3. Программа устанавливается в `Program Files`
4. Все заявки сохраняются локально в `requests.db` рядом с `.exe`

---

## 🚀 Сборка вручную

1. Клонируйте репозиторий
2. Откройте `.sln` в **Visual Studio**
3. Установите NuGet пакет: `System.Data.SQLite`
4. Сборка → Release
5. Файл будет в `bin/Release/ProductionRequestManager.exe`

---

## 📦 Сборка инсталлятора

1. Установите [Inno Setup](https://jrsoftware.org/isinfo.php)
2. Используйте файл `InstallerScript.iss`
3. Компилируйте установщик — он добавит иконку, ярлык, меню "Пуск"

---

## 📄 Лицензия

MIT License — свободно используйте, изменяйте и распространяйте ❤️
