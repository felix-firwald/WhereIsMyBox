FIELD_ERROR_MESSAGE = "Foreign Key должен обращаться к конкретному полю таблицы, которое не указано"
NO_FIELDS_ERROR_MESSAGE = "Таблица не содержит ни одного поля"


class FieldConstraintFailed(Exception):
    def __init__(self, message):
        super().__init__(message)


def get_with_space(string: str, space: int = 20) -> str:
    space = " " * (space - len(string))
    return string + space


class Field:
    def __init__(
            self,
            name: str,
            data_type: str,
            is_null: bool = False,
            is_unique: bool = False,
            default: str = None,
            foreign_key: str = None,
            foreign_key_field: str = None
    ) -> None:
        self.name = name
        self.type = data_type.upper()
        self.is_null = is_null
        self.is_unique = is_unique
        self.default = default
        self.f_k_table = foreign_key
        self.f_k_field = foreign_key_field
        self.check_constraints()

    def check_constraints(self) -> None:
        if self.is_unique is True and self.is_null is True:
            raise FieldConstraintFailed(
                f"Поле {self.name} не может допускать NULL"
            )
        if self.default is not None:
            if "INT" in self.type and not self.default.isdigit():
                raise FieldConstraintFailed(
                    f"Поле {self.name} имеет тип {self.type}, но дефолтное значение - {self.default}"
                )
        if self.f_k_table is not None:
            if self.f_k_field is None:
                raise FieldConstraintFailed(
                    f"Для {self.f_k_table} не указано поле"
                )

    def get_name(self) -> str:
        return get_with_space(self.name)

    def get_type(self) -> str:
        return get_with_space(str(self.type).upper())

    def get_null(self) -> str:
        return "" if self.is_null else get_with_space("NOT NULL")

    def get_uniq(self) -> str:
        return get_with_space("UNIQUE") if self.is_unique else ""

    def get_default(self) -> str:
        c = "'"
        if "INT" in self.type or "BIT" in self.type or "DECIMAL" in self.type:
            c = ""
        return get_with_space(f"DEFAULT {c}{self.default}{c}") if self.default is not None else ""

    def get_foreign(self) -> str:
        if self.f_k_table is not None:
            cmd = "FOREIGN KEY REFERENCES"
            return f"{cmd} {self.f_k_table} ({self.f_k_field})"
        return ""

    def get_string(self) -> str:
        init_space = " " * 8
        string1 = f"{self.get_name()}{self.get_type()}{self.get_null()}"
        string2 = f"{self.get_uniq()}{self.get_default()}{self.get_foreign()}"
        result = init_space + string1 + string2
        return result.rstrip()


class Model:
    def __init__(self, name: str, fields: list) -> None:
        self.name = name
        self.fields = fields

    def create_table(self) -> str:
        start = f"CREATE TABLE {self.name} (\n"
        middle = ""
        end = ");\n"
        if not self.fields:
            raise FieldConstraintFailed(NO_FIELDS_ERROR_MESSAGE)

        length = len(self.fields)
        count = 1
        for field in self.fields:
            last_char = ",\n"
            if count == length:
                last_char = "\n"
            count += 1
            middle += (field.get_string() + last_char)
        return start + middle + end

    def __str__(self) -> str:
        return self.name
