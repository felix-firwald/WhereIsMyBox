CREATE TABLE Locations (
        name                NVARCHAR(40)        NOT NULL            UNIQUE
);
CREATE TABLE Places (
        name                NVARCHAR(4)         NOT NULL            UNIQUE
);
CREATE TABLE Types (
        name                NVARCHAR(50)        NOT NULL            UNIQUE
);
CREATE TABLE Boxes (
        number              VARCHAR(10)         NOT NULL            UNIQUE,
        location            NVARCHAR(40)        NOT NULL            FOREIGN KEY REFERENCES Locations (name),
        status              TINYINT             NOT NULL            DEFAULT 1,
        type                NVARCHAR(50)        NOT NULL            FOREIGN KEY REFERENCES Types (name),
        note                NVARCHAR(75)
);
CREATE TABLE Batches (
        id                  INT IDENTITY(1,1)   NOT NULL,
        number              VARCHAR(30)         NOT NULL            UNIQUE,
        box                 VARCHAR(10)         NOT NULL            FOREIGN KEY REFERENCES Boxes (number)
);
CREATE TABLE Units (
        name                NVARCHAR(50)        NOT NULL            UNIQUE
);
CREATE TABLE Users (
        id                  INT IDENTITY(1,1)   NOT NULL,
        login               VARCHAR(30)         NOT NULL            UNIQUE,
        status              TINYINT             NOT NULL            DEFAULT 0,
        unit                NVARCHAR(50)        NOT NULL            FOREIGN KEY REFERENCES Units (name)
);
CREATE TABLE BoxesInUse (
        id                  INT IDENTITY(1,1)   NOT NULL,
        box                 VARCHAR(10)         NOT NULL            FOREIGN KEY REFERENCES Boxes (number),
        place               NVARCHAR(4)         NOT NULL            FOREIGN KEY REFERENCES Places (name),
        customer            VARCHAR(30)         NOT NULL            FOREIGN KEY REFERENCES Users (login),
        timeStarted         SMALLDATETIME       NOT NULL,
        timeFinished        SMALLDATETIME       NOT NULL,
        inFocus             BIT                 NOT NULL            DEFAULT 0,
        finished            BIT                 NOT NULL            DEFAULT 0
);
