from random import choice, randint
from string import ascii_uppercase, ascii_lowercase

FILE_PATH = "D:\\Dev\\WIMB\\WhereIsMyBox\\pythonScripts\\script"

FILE_LOCATIONS = open(
    f"{FILE_PATH}1. Locations.txt", "w"
)
FILE_PLACES = open(
    f"{FILE_PATH}2. Places.txt", "w"
)
FILE_STATUSES = open(
    f"{FILE_PATH}3. Statuses.txt", "w"
)
FILE_TYPES = open(
    f"{FILE_PATH}4. Types.txt", "w"
)
FILE_BOXES = open(
    f"{FILE_PATH}5. Boxes.txt", "w"
)
FILE_BATCHES = open(
    f"{FILE_PATH}6. Batches.txt", "w"
)
FILE_USERS = open(
    f"{FILE_PATH}7. Users.txt", "w"
)

STATUS = [
    "Operator",
    "Moderator",
    "Admin"
]
GROUP = [
    "Изъятие",
    "Архивариусы",
    "Контроль качества",
    "Дежурные",
    "Сканировщики",
    "Группа разбора корреспонденции"
]

BOX_STATUSES = [
    "Изъят",
    "Доступен",
    "Отправлен в архив",
    "Не найден"
]

TYPES = [
    "Суды",
    "ФССП",
    "Толстые суды",
    "Розыск счетов",
    "Клиентское письмо",
    "Розыск с возвратом",
    "Неколлекшн",
    "ОТП",
    "ТРАСТ",
    "Русфинанс банк",
    "АТБ",
    "Феникс клиентские",
    "Связной",
    "ТКС Агенты",
    "КАСКО",
    "УО_почта"
]

NOTES = [
    "Не забирать короб!",
    "Короб уехал нахуй",
    "Где блять этот короб ебучий?",
    "Короб где-то у архивариуса но он в очередной раз забыл это отметить"
]

BOX_LOCATIONS = [
    "КП Феникс",
    "Сканировщики",
    "Переговорная 26-22 (1 ряд)",
    "Переговорная 26-22 (2 ряд)",
    "Переговорная 26-22 (3 ряд)",
    "Переговорная 26-22 (4 ряд)",
    "Переговорная 26-23 (утиль)",
    "Переговорная 26-23 (ОНЗ)",
    "Переговорная 26-24 (РСВ)",
    "Переговорная 26-24 (право)",
    "Переговорная 26-24 (неколлекшн)",
    "Стеллаж",
    "Открытые",
    "Поточные",
    "Дежурные",
    "Приоритет для архивариуса",
    "Неколлекшн архивариус",
    "Архивариус",
    "Сверка (Левая)",
    "Сверка (Правая)",
    "Сверка (Контроль качества)",
    "Выход (отправка)"
]

USERS_SURNAMES = [
    'anisimov',
    'annenkov',
    'antonov',
    'argunov',
    'bagration',
    'bakunin',
    'balashov',
    'batyushkov',
    'beketov',
    'belinskiy',
    'belov',
    'belyakov',
    'berestov',
    'bessonov',
    'bestuzhev',
    'blinov',
    'bobrinskiy',
    'bobrov',
    'bogatov',
    'bogdanov',
    'bulatov',
    'bunin',
    'danilov',
    'davydov',
    'denisov',
    'gorskiy',
    'gromov',
    'grusheckiy',
    'grushevskiy',
    'guschin',
    'gusev',
    'klementev',
    'knyazev',
    'kostrov',
    'kotov',
    'kovalenskiy',
    'kovalev',
    'kovalevskiy',
    'kozlov',
    'kozlovskiy',
    'lanskoy',
    'lapin',
    'larionov',
    'lavrentev',
    'lavrov',
    'magon'
]


def random_status():
    r = randint(1, 2)
    if r == 1:
        return STATUS[0]
    else:
        return choice(STATUS)


def random_box_status():
    return choice(BOX_STATUSES)


def random_type():
    return choice(TYPES)


def random_note():
    return choice(NOTES)


def random_access():
    return "Доступен" if randint(0, 1) == 1 else "Изъят"


def create_types(t):
    FILE_TYPES.write(
        "INSERT INTO Types" +
        "(name) " +
        f"VALUES('{t}')\n"
    )


def create_box_statuses(n):
    FILE_STATUSES.write(
        "INSERT INTO Statuses" +
        "(name) " +
        f"VALUES('{n}')\n"
    )


def create_box(number, boxloc, userloc):
    FILE_BOXES.write(
        "INSERT INTO Boxes" +
        "(number, initialLocation, currentPlace, status, type, note) " +
        f"VALUES('{number}', '{boxloc}', '{userloc}', " +
        f"'{random_box_status()}', '{random_type()}', '{random_note()}')\n"
    )


def create_batch(number, box):
    FILE_BATCHES.write(
        "INSERT INTO Batches" +
        "(number, box) " +
        f"VALUES({number}, '{box}')\n"
    )


def create_location(loc):
    FILE_LOCATIONS.write(
        "INSERT INTO Locations" +
        "(name) " +
        f"VALUES('{loc}')\n"
    )


def create_place(prefix, num):
    FILE_PLACES.write(
        "INSERT INTO Places" +
        "(name) " +
        f"VALUES('{prefix}{num}')\n"
    )


def create_user(name, surname):
    print(f"{name}.{surname}")
    FILE_USERS.write(
        "INSERT INTO Users" +
        "(login, status, isOnline) " +
        f"VALUES('{name}.{surname}', '{random_status()}', '0')\n"
    )


for surname in USERS_SURNAMES:
    if surname != "magon":
        create_user(choice(ascii_lowercase), surname)
    else:
        create_user("d", surname)


for type in TYPES:
    create_types(type)

for status in BOX_STATUSES:
    create_box_statuses(status)

for prefix in "ABCDEFJH":
    for num in range(1, 15):
        create_place(prefix, num)
        print(f"{prefix}{num}")

for location in BOX_LOCATIONS:
    create_location(location)
    print(location)


batch_number = 111001
for first in ascii_uppercase:
    for second in ascii_uppercase:
        for num in range(17234, 17237):
            loc = choice(BOX_LOCATIONS)
            box = f"{first}{second}{num}"
            create_box(box, loc, "A1")
            print(f"{box} - {loc}")
            for j in range(1, 7):
                print(f"{box}: {batch_number}")
                create_batch(batch_number, box)
                batch_number += 1
