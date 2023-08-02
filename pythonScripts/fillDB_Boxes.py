from random import choice, randint
from string import ascii_uppercase, ascii_lowercase

FILE_PATH = "D:\\Dev\\WIMB\\WhereIsMyBox\\pythonScripts\\script"

FILE_MAIN = open(
    f"{FILE_PATH}1. GeneratedData.sql", "w"
)
FILE_LOCATIONS = open(
    f"{FILE_PATH}2. Locations.txt", "w"
)
FILE_PLACES = open(
    f"{FILE_PATH}3. Places.txt", "w"
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
FILE_UNITS = open(
    f"{FILE_PATH}7. Units.txt", "w"
)
FILE_USERS = open(
    f"{FILE_PATH}8. Users.txt", "w"
)
TABLES = [
    "BoxesInUse",
    "Users",
    "Units",

    "Boxes",
    "Batches",

    "Locations",
    "Places",
    "Types",
]
STATUS = [
    "Operator",
    "Moderator",
    "Admin"
]
UNITS = [
    "Изъятие",
    "Архивариусы",
    "Контроль качества",
    "Дежурные",
    "Сканировщики",
    "Группа разбора корреспонденции"
]

BOX_STATUSES = [
    "Available",
    "Seized",
    "Undefined",
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
    "Короб где-то у архивариуса"
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
    'magon',
    'felix'
]


def random_status():
    r = randint(1, 2)
    if r == 1:
        return STATUS[0]
    else:
        return choice(STATUS)


def random_unit():
    return choice(UNITS)


def random_box_status():
    return choice(BOX_STATUSES)


def random_type():
    return choice(TYPES)


def random_note():
    return choice(NOTES)


def random_access():
    return "Available" if randint(0, 1) == 1 else "Seized"


def clearAllData():
    string = ""
    for tab in TABLES:
        string += f"""DELETE FROM {tab}\n"""
    string += "\n"
    FILE_MAIN.write(string)


def create_types(t):
    string = f"INSERT INTO Types (name) VALUES('{t}')\n"
    FILE_MAIN.write(string)
    FILE_TYPES.write(string)


def create_box_statuses(n):
    string = f"INSERT INTO Statuses (name) VALUES('{n}')\n"
    FILE_MAIN.write(string)
    # FILE_STATUSES.write(string)


def create_box(number, boxloc):
    string = f"""INSERT INTO Boxes (number, location, status, type, note)
        VALUES('{number}', '{boxloc}', '{random_box_status()}', '{random_type()}', '{random_note()}')\n"""
    FILE_MAIN.write(string)
    FILE_BOXES.write(string)


def create_batch(number, box):
    string = f"""INSERT INTO Batches(number, box) VALUES({number}, '{box}')\n"""
    FILE_MAIN.write(string)
    FILE_BATCHES.write(string)


def create_location(loc):
    string = f"""INSERT INTO Locations (name) VALUES('{loc}')\n"""
    FILE_MAIN.write(string)
    FILE_LOCATIONS.write(string)


def create_place(prefix, num):
    string = f"""INSERT INTO Places (name) VALUES('{prefix}{num}')\n"""
    FILE_MAIN.write(string)
    FILE_PLACES.write(string)


def create_unit(name):
    print(f"{name}")
    string = f"""INSERT INTO Units (name) VALUES('{name}')\n"""
    FILE_MAIN.write(string)
    FILE_UNITS.write(string)


def create_user(name, surname):
    print(f"{name}.{surname}")
    if surname == "felix":
        string = f"""INSERT INTO Users (login, status, unit, isOnline) VALUES('{surname}', '{random_status()}', '{random_unit()}', '0')\n"""
    else:
        string = f"""INSERT INTO Users (login, status, unit, isOnline) VALUES('{name}.{surname}', '{random_status()}', '{random_unit()}', '0')\n"""
    FILE_MAIN.write(string)
    FILE_USERS.write(string)


clearAllData()

# LOCATIONS
for location in BOX_LOCATIONS:
    create_location(location)
    print(location)

# PLACES
for prefix in "ABCDEFJH":
    for num in range(1, 15):
        create_place(prefix, num)
        print(f"{prefix}{num}")

# TYPES
for type in TYPES:
    create_types(type)

# BOXES & BATCHES
randing = [*range(17170, 17200), *range(17220, 17240)]
batch_number = 111001
for first in ascii_uppercase:
    for second in ascii_uppercase:
        for num in randing:
            loc = choice(BOX_LOCATIONS)
            box = f"{first}{second}{num}"
            create_box(box, loc)
            print(f"\n\n{box} - {loc}")
            # for j in range(1, 3):
            #    print(f"{box}: {batch_number}")
            #    create_batch(batch_number, box)
            #    batch_number += 1

# UNITS
for unit in UNITS:
    create_unit(unit)

for surname in USERS_SURNAMES:
    if surname != "felix":
        create_user(choice(ascii_lowercase), surname)
    else:
        create_user("d", surname)
