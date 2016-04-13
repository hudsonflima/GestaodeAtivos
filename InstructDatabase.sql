﻿CREATE TABLE [dbo].[CadastroAplicacao] (
    [AppId] [int] NOT NULL IDENTITY,
    [Nome] [varchar](100) NOT NULL,
    [Gratuito] [bit] NOT NULL,
    [Trial] [bit] NOT NULL,
    [Pago] [bit] NOT NULL,
    CONSTRAINT [PK_dbo.CadastroAplicacao] PRIMARY KEY ([AppId])
)
CREATE TABLE [dbo].[CadastroComputador] (
    [ComputadorId] [int] NOT NULL IDENTITY,
    [Hostname] [varchar](100),
    [Enderecoip] [varchar](100),
    [Mac] [varchar](100),
    [Setor] [varchar](100),
    CONSTRAINT [PK_dbo.CadastroComputador] PRIMARY KEY ([ComputadorId])
)
CREATE TABLE [dbo].[CadastroFuncao] (
    [FuncaoId] [int] NOT NULL IDENTITY,
    [NomeFuncao] [varchar](100) NOT NULL,
    [Aplicacoes] [varchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.CadastroFuncao] PRIMARY KEY ([FuncaoId])
)
CREATE TABLE [dbo].[CadastroLicenciamento] (
    [LicenciamentoId] [int] NOT NULL IDENTITY,
    [SistemaOperacional] [varchar](100) NOT NULL,
    [Versao] [varchar](100) NOT NULL,
    [Serial] [varchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.CadastroLicenciamento] PRIMARY KEY ([LicenciamentoId])
)
CREATE TABLE [dbo].[CadastroServidor] (
    [ServidorId] [int] NOT NULL IDENTITY,
    [Hostname] [varchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.CadastroServidor] PRIMARY KEY ([ServidorId])
)
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201604081938101_AutomaticMigration', N'Gestao.Infra.Data.Migrations.Configuration',  0x1F8B0800000000000400D55AC972E33610BDA72AFFC0E2D9237AB9242E69A63CF21257C64B0DEDB943644B46850418027459DF96C37C527E210D7103575324652935971108BC6E345E03BDF8DF7F7E4EBFBCF99EF10AA1A09CCDCC93C9B1690073B84BD96A664672F9E937F3CBE75F7F995EB9FE9BF1239D77A6E6E14A2666E68B94C1B96509E7057C22263E75422EF8524E1CEE5BC4E5D6E9F1F1EFD6C9890508612296614CBF474C521F363FF0E79C3307021911EF8EBBE089641CBFD81B54E39EF82002E2C0CCBC0121099FDCB265482697449209AE96F026B9695C7894A04636784BD3208C714924EA7BFE2CC09621672B3BC001E23DAD03C0794BE20948F6719E4FEFBAA5E353B5252B5F9842399190DCDF12F0E42CB191555EDECBD2666643B4E2155A5BAED5AE37969C9973E2128116B9083CEA1087A0EDCA52CFE75EA8566416BFC4AF944D365814C4A482716414661E65744156A97F47C63CF26414C28C412443E21D198FD10217FF09EB27FE17B0198B3C4F571C55C76F85011C7A0C7900A15C7F8765B29D8B20B8754DC32A2EB5CA6BB395C565F12E6F993C3B358D7B54812C3CC8D8A159C4963C841B60101209EE239112423CDC5B1736F6AD28501277CF7D48A5211DD1C34CE38EBC7D03B6922FE87BC7E853D7F40DDC7424D1E0995174485C24C3086A346C977A83CA465479472CF92BE71E10B635CE53888E3314E491ACB654646AE5E4ED44E939F78348A2378403389D83EC8FD4B90E7DB85D5CFD5114FF830BC9C828346F1774C55C08C1E134D8B9A83BE2EC5C860D52F17554295B7BCE75C486BD0431C0FE3C2696DFC75BF2951FF918A406FFE8272179B139885DCBDE9A83DFA883E127C531268750B180B33F4616D4E843CC0AC047F1D3A6426294F98063C441BCFCEDFF389EAA63DA877FD8A0C73A07E31BA8D62B1D16D7A410FBF38854833ECEA0AFFD1F463403D8A0525C3C2708D3A01E4F8F8779E25B210466BC09274422BEB8CB1816C38EFA8470F334E40AC5297535E3AB18AF09368F465B81F5D8BD23B27A43DBB54D5FD98E80851BB70DB7F45475844F39DCAA72EEE97514C9C8909749ACB84E92D653AC8682CAF48E0401D2572BB02423861D5757E69FECEDCB0D7E8C6139A2A6EA90699B4942E6921594BEAA8CC5856B1A0AA98A3A0BA21C64EEFA956925EA37583D15D6C8EEF24D959F45BA54FD3FF7B6FA92538D4B948073135FE3AE15573606804CD3BA624C05635309231E09EB2B1873EE453E6BA985B461C465091D221EE98E90971874947CB43B525264D06192A1EE18718D41878847AA0853AB74346552581556945EAC32DFB66263E1521C998FDA4DDA9F906D204DD62FD61DF45368AB67B421E62FB08E968F7647D28B063A963EDE1D6D5317D0613603DDD72739BF8E900C1D1C53D347766492262F737F82360134993C4FF375AB37950DDA90F4F4BD7C75D6071C6D687AD455BCCBF3F183234529501A991BC5E8AA3F45DEC1693A914ADEAD1FCB3B597D1B6E5D5A5DB8016ABE77474F13661D311DDBE662AABEC2E9D8C1B1508BA74766601684F7275F33448BEDB314B764FF86B4B90D6DFBA773A7A7594960CA5332E95922534A58A649F2F07E9BB8924DC4534C034D8496549984BD56BE169FBEFDB737F728EE379F7047185D224DE27A87797A7C725AEA301F4EB7D712C2F5B66DF9EEA9D14A9591DFADCA6C59B2D37BABAF24745E4858ADD10CEC9C2EA81CD635ED03A0774CDF5F3FA45B7A102DCA9D90A35CC3EB40907E3DC89180B58EE3488885FE622FCCBEDDC4BDB6F17676D5143B77635D38D5BE5C3FE4815DB703EA73EDE4009B5B5B631D64B17135166AB12DF541D4A80F61F7D1EB3994A76170F3A65AE8DEAA37A388D5A5351307BC33D35D2826C6BA8FD1C1E9D8BF6913DFB3CFD3BAF374429BDC21ADA0EE9DA0360D86358D3AB58CDAC40F6E2C55F3AFA9A5FF31EFF412045DE510EA4F7B19382AB1C941D339987DF3D41F71D3BA46E994726404C81AF49A8B50D22571247E7640884D47F607F1221595F90B706FD943249162174280BFF00A5DDEA9D52E7FD33D2BEA3C7D08D42F31C616504D8A5B8007F635A29E9BE97D5D73AD3440A80B24B903512B5BAABB70B5CE90EE39EB089498EF120260EA067D023FF0104C3C309BBC421FDD9E057C831571D6691ADD0CF2FE4114CD3EBDA46415125F2418F97AFC891C76FDB7CFFF0176CEC616D32E0000 , N'6.1.3-40302')
