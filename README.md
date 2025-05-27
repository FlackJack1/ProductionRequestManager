# ProductionRequestManager

📦 Простое приложение на Windows Forms для учёта и управления заявками на производство.

## 🚀 Возможности

- Добавление, редактирование и удаление заявок
- Хранение данных в SQLite
- Поиск и фильтрация по статусу или ключевым словам
- Экспорт заявок в XML
- Установка с иконкой через Inno Setup

## 🛠️ Используемые технологии

- C#, WinForms (.NET Framework 4.8)
- SQLite (через System.Data.SQLite)
- Inno Setup (инсталлятор)

## 🧰 Сборка проекта

1. Открыть `.sln` в Visual Studio
2. Установить пакет `System.Data.SQLite` через NuGet
3. Сборка в режиме `Release`

## 📦 Сборка инсталлятора

Файл `InstallerScript.iss` позволяет собрать установщик через Inno Setup.

## 📄 Лицензия

[MIT License](LICENSE)
