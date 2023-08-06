from random import choice, randint
from string import ascii_uppercase, ascii_lowercase

from CreateTables import TABLES

FILE_PATH = "D:\\Dev\\WIMB\\WhereIsMyBox\\pythonScripts\\script"

CREATE_FILE = open(
    f"{FILE_PATH}0. CreateTables.sql",
    "w"
)

FILE_DROP = open(
    f"{FILE_PATH}1. Drop.sql", "w"
)

FILE_MAIN = open(
    f"{FILE_PATH}2. GeneratedData.sql", "w"
)

STATUS = [
    "0",
    "1",
    "2"
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
    # "0",  # не определен
    "1",  # доступен
    "2",  # изъят
    "3",  # изъят в фокусе
    "4"  # утерян
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

RequiredUsings = []
UsersList = []

def create_tables():
    for table in TABLES:
        result = table.create_table()
        print(result)
        CREATE_FILE.write(result)


def drop_table(tablename):
    FILE_DROP.write(f"DROP TABLE {tablename};\n")


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
        string += f"""DELETE FROM {tab};\n"""
    string += "\n"
    FILE_MAIN.write(string)


def create_types(t):
    string = f"INSERT INTO Types (name) VALUES('{t}')\n"
    FILE_MAIN.write(string)
    # FILE_TYPES.write(string)


def create_box_statuses(n):
    string = f"INSERT INTO Statuses (name) VALUES('{n}')\n"
    FILE_MAIN.write(string)
    # FILE_STATUSES.write(string)


def create_using(box, focused):
    string1 = "INSERT INTO BoxesInUse (box, place, customer, timeStarted, timeFinished, inFocus, finished)"
    string2 = f"\nVALUES ('{box}', 'H5', '{choice(UsersList)}', '01.01.2001 00:00:00', '12.01.2024 00:00:00', {focused}, 0)\n"
    result = string1 + string2
    print(result)
    FILE_MAIN.write(result)


def create_box(number, boxloc):
    status = random_box_status()
    string = "INSERT INTO Boxes (number, location, status, type, note)"
    string2 = f"VALUES('{number}', '{boxloc}', '{status}', '{random_type()}', '{random_note()}')\n"
    if status == "2" or status == "3":
        RequiredUsings.append([number, "0" if status == "2" else "1"])
    result = string + string2
    FILE_MAIN.write(result)
    # FILE_BOXES.write(string)


def create_batch(number, box):
    string = f"""INSERT INTO Batches(number, box) VALUES({number}, '{box}')\n"""
    FILE_MAIN.write(string)
    # FILE_BATCHES.write(string)


def create_location(loc):
    string = f"""INSERT INTO Locations (name) VALUES('{loc}')\n"""
    FILE_MAIN.write(string)
    # FILE_LOCATIONS.write(string)


def create_place(prefix, num):
    string = f"""INSERT INTO Places (name) VALUES('{prefix}{num}')\n"""
    FILE_MAIN.write(string)
    # FILE_PLACES.write(string)


def create_unit(name):
    print(f"{name}")
    string = f"""INSERT INTO Units (name) VALUES('{name}')\n"""
    FILE_MAIN.write(string)
    # FILE_UNITS.write(string)


def create_user(name, surname):
    print(f"{name}.{surname}")

    if surname == "felix":
        string = f"""INSERT INTO Users (login, status, unit) VALUES('{surname}', '{random_status()}', '{random_unit()}')\n"""
        UsersList.append(f"{surname}")
    else:
        string = f"""INSERT INTO Users (login, status, unit) VALUES('{name}.{surname}', '{random_status()}', '{random_unit()}')\n"""
        UsersList.append(f"{name}.{surname}")
    FILE_MAIN.write(string)
    # FILE_USERS.write(string)


create_tables()

TABLES.reverse()

for table in TABLES:
    drop_table(table)

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

for use in RequiredUsings:
    create_using(use[0], use[1])
