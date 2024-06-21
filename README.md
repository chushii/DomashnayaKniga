# DomashnayaKniga (.NET Core 8.0)
Разработать АИС для библиотеки DomashnayaKniga. Система должна регистрировать клиентов, вести учет книг, отслеживать бронь и аренду книг. Книги делятся по жанрам, их можно взять напрокат или читать в одном из залов. Библиотека также обладает компьютерным залом, где читатели могут воспользоваться электронными библиотечными ресурсами.
БД должна содержать данные о читателях, книгах, брони и аренде, залах, лицензиях электронных библиотек, имеющихся компьютерах и их состоянии.

Состояние проекта:
- Простая регистрация с добавлением пользователя в БД
- Хеширование паролей — MD5 + соль
- Юнит-тестирование — только для хеширования
- Небольшая база данных — 4 таблицы, из них 3 с внешними ключами
- ORM — все CRUD операции, готов на 100%
- SQL — пока только определяет название таблицы и некоторые возможные ошибки