from Classes import Model, Field

TABLES = [
    Model(
        "Locations",
        [Field("name", "NVARCHAR(40)", is_null=False, is_unique=True)]
    ),
    Model(
        "Places",
        [Field("name", "NVARCHAR(4)", is_null=False, is_unique=True)]
    ),
    Model(
        "Types",
        [Field("name", "NVARCHAR(50)", is_null=False, is_unique=True)]
    ),
    Model(
        "Boxes",
        [
            Field("number", "VARCHAR(10)", is_null=False, is_unique=True),
            Field(
                "location", "NVARCHAR(40)", is_null=False,
                foreign_key="Locations", foreign_key_field="name"
            ),
            Field("status", "TINYINT", is_null=False, default="1"),
            Field(
                "type", "NVARCHAR(50)", is_null=False,
                foreign_key="Types", foreign_key_field="name"
            ),
            Field("note", "NVARCHAR(75)", is_null=True),
        ]
    ),
    Model(
        "Batches",
        [
            Field(
                "id",
                "INT IDENTITY(1,1)",
            ),
            Field(
                "number",
                "VARCHAR(30)",
                is_unique=True
            ),
            Field(
                "box",
                "VARCHAR(10)",
                foreign_key="Boxes",
                foreign_key_field="number"
            )
        ]
    ),
    Model(
        "Units",
        [Field("name", "NVARCHAR(50)", is_unique=True)]
    ),
    Model(
        "Users",
        [
            Field(
                "id",
                "INT IDENTITY(1,1)",
            ),
            Field(
                "login",
                "VARCHAR(30)",
                is_unique=True
            ),
            Field(
                "status",
                "TINYINT",
                default="0"
            ),
            Field(
                "unit",
                "NVARCHAR(50)",
                foreign_key="Units",
                foreign_key_field="name"
            )
        ]

    ),
    Model(
        "BoxesInUse",
        [
            Field(
                "id",
                "INT IDENTITY(1,1)",
            ),
            Field(
                "box",
                "VARCHAR(10)",
                foreign_key="Boxes",
                foreign_key_field="number"
            ),
            Field(
                "place",
                "NVARCHAR(4)",
                foreign_key="Places",
                foreign_key_field="name"
            ),
            Field(
                "customer",
                "VARCHAR(30)",
                foreign_key="Users",
                foreign_key_field="login"
            ),
            Field(
                "timeStarted",
                "SMALLDATETIME",
            ),
            Field(
                "timeFinished",
                "SMALLDATETIME",
            ),
            Field(
                "inFocus",
                "BIT",
                default="0"
            ),
            Field(
                "finished",
                "BIT",
                default="0"
            ),
        ]
    )
]
