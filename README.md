# ТРПО
## <a name="Content"></a> Содержание
1. [Лабораторная работа №1](#LR1)
2. [Лабораторная работа №2](#LR2)
3. [Лабораторная работа №3](#LR3)
4. [Лабораторная работа №4.1](#LR4_1)
5. [Лабораторная работа №4.2](#LR4_2)
6. [Лабораторная работа №5](#LR5)

## <a name="LR1"></a> ЛР1 [вверх](#Content)
### Определить основные процессы работы любого предприятия: определить бизнес-процессы и промоделировать их на языке IDEF0, дополнить IDEF3 & DFD.

Результат работы:   
Определим процессы работы криптобиржи для покупки токенезированных аналагов акций предприятия.

Обобщенная модель предприятия (IDEF0):
![](/lab1/img/idef0_a_0.png)

Подробная модель предприятия (IDEF0):
![](/lab1/img/idef0_a_0_1_1.png)

Логика взаимодействия информационных потоков системы (IDEF3):
![](/lab1/img/idef3.png)

Механизмы передачи и обработки информации в системе (DFD):
![](/lab1/img/dfd.png)

Декомпозированная модель DFD:
![](/lab1/img/dfd_decomposition.png)


## <a name="LR2"></a> ЛР2 [вверх](#Content)
### Разработать требования к изделию (ТЗ)

Результат работы:   
Документ с техническим заданием: [ТРПО_ТЗ_Криптобиржа.docx](/lab2/ТРПО_ТЗ_Криптобиржа.docx)
![](/lab2/images/1.png)
![](/lab2/images/2.png)
![](/lab2/images/3.png)
![](/lab2/images/4.png)
![](/lab2/images/5.png)
![](/lab2/images/6.png)
![](/lab2/images/7.png)
![](/lab2/images/8.png)
![](/lab2/images/9.png)


## <a name="LR3"></a> ЛР3 [вверх](#Content)
### Описать в табличном и текстовом спец виде USE CASE для реализации требований.

Результат работы:
![](/lab3/img/1.png)
![](/lab3/img/2.png)
![](/lab3/img/3.png)
![](/lab3/img/4.png)

## <a name="LR4_1"></a> ЛР4.1 [вверх](#Content)
### На языке UML спроектировать ПО:
- написать USE CASE для тербований
- промоделировать реализацию use case с помощью и 
- перейти и выполнить моделирование с помощью диаграммы классов, получить код для реализации.
- построить диаграмму компонент из диаграм классов
- получить приложение и показать его работу



Диаграмма классов:
![](/lab4_1/images/class_diagram.png)

Результат работы:

## <a name="LR4_2"></a> ЛР4.2 [вверх](#Content)
### На языке IDEF1X спроектировать БД, сгенерировать DDL и отчеты, построить БД, котороая будет применяться в п. 4.1.

Результат работы:   
IDEF1X:
![](/lab4_2/img/diagram.png)

DDL:
Client:
``` SQL

CREATE TABLE [dbo].[Client]
(
	[ClientID] UNIQUEIDENTIFIER NOT NULL, 
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL, 
    [PhoneNumber] VARCHAR(30) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [Photo] VARBINARY(MAX) NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ClientID] ASC)
)


```

ClientAccount:
``` SQL

CREATE TABLE [dbo].[ClientAccount]
(
	[ClientAccountID] UNIQUEIDENTIFIER NOT NULL, 
    [ClientID] UNIQUEIDENTIFIER NOT NULL, 
    [FiatMoney] MONEY NOT NULL, 
    CONSTRAINT [PK_ClientAccount] PRIMARY KEY CLUSTERED ([ClientAccountID] ASC), 
    CONSTRAINT [FK_ClientAccount_Client] FOREIGN KEY ([ClientID]) REFERENCES [dbo].[Client]([ClientID])
)


```

AccountAsset:
``` SQL

CREATE TABLE [dbo].[AccountAsset]
(
	[AssetID] BIGINT NOT NULL, 
    [ClientAccountID] UNIQUEIDENTIFIER NOT NULL, 
    [AssetHolderID] UNIQUEIDENTIFIER NOT NULL, 
    [TokensCount] BIGINT NOT NULL, 
    CONSTRAINT [PK_AccountAsset] PRIMARY KEY CLUSTERED ([AssetID] ASC), 
    CONSTRAINT [FK_AccountAsset_ClientAccount] FOREIGN KEY ([ClientAccountID]) REFERENCES [dbo].[ClientAccount]([ClientAccountID]), 
    CONSTRAINT [FK_AccountAsset_AssetHolder] FOREIGN KEY ([AssetHolderID]) REFERENCES [dbo].[AssetHolder]([AssetHolderID])
)


```

AssetHolder:
``` SQL

CREATE TABLE [dbo].[AssetHolder]
(
	[AssetHolderID] UNIQUEIDENTIFIER NOT NULL, 
    [CompanyName] VARCHAR(50) NOT NULL, 
    [AvailaibleTokens] BIGINT NOT NULL, 
    CONSTRAINT [PK_AssetHolder] PRIMARY KEY ([AssetHolderID])
)

```


## <a name="LR5"></a> ЛР5 [вверх](#Content)
### Выполнить тестирование по любому критерию.

Результат работы:
