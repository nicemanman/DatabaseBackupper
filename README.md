﻿# DatabaseBackupper
Данная небольшая программа возникла после того, как я по неосторожности потерял свои MS SQL базы данных. Она до сих пор в процессе разработки, в данный момент я переношу ее достаточно скромный функционал на паттерн Model-View-Presenter.

БАГИ:
1 - Если удалить файлы базы данных, в которой хранится программная информация, программа не сможет создать еще одну. Пока еще не разобрался с этим:)

В ПЛАНАХ:
1 - Бэкап баз данных с локального пк на удаленный, на облачный диск Google, Yandex и Dropbox
2 - Бэкап баз данных MySQL и Postgres
3 - Бэкап баз данных по расписанию. Это почти готово, в старой версии уже работает, переношу эту тему на MVP:)

Приложение в Google не верифицировано, поэтому подключение к google диску будет доступно только тем пользователям, которых я лично добавлю. Решил с этим особо не заморачиваться, т.к. сомневаюсь что приложением будет пользоваться много народа. В принципе, если вам будет нужно, сделать себе приложение в консоли разработчика google не сложно:)
