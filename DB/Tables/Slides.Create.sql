-- Slides Table ========================
CREATE TABLE Slides (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Title nvarchar(200)  NOT NULL,
    Description nvarchar(200)  NOT NULL,
    LinkUrl nvarchar(200)  NOT NULL,
    LinkText nvarchar(200)  NOT NULL,
    DisplayOrder int  NOT NULL,
    Image_FileName nvarchar(1500)  NULL
);

