USE [frigorifico2]
GO
/****** Object:  Table [dbo].[pessoa]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pessoa](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[telefone] [varchar](14) NULL,
	[celular] [varchar](14) NOT NULL,
	[email] [varchar](70) NOT NULL,
	[estado] [varchar](30) NULL,
	[cep] [varchar](12) NOT NULL,
	[municipio] [varchar](30) NULL,
	[complemento] [varchar](12) NOT NULL,
	[numero] [varchar](3) NOT NULL,
	[senha] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[entregador]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entregador](
	[matricula] [int] IDENTITY(1,1) NOT NULL,
	[habilitacao] [varchar](11) NOT NULL,
	[id_pessoa] [int] NOT NULL,
	[nome] [varchar](180) NOT NULL,
	[tipoHabilitacao] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[solicitacao]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solicitacao](
	[id_solicitacao] [int] IDENTITY(1,1) NOT NULL,
	[id_itens] [int] NOT NULL,
	[descricao] [text] NOT NULL,
	[id_pessoa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_solicitacao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](180) NOT NULL,
	[peso] [float] NOT NULL,
	[preco] [real] NOT NULL,
	[id_tipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fornecedor](
	[nome] [varchar](120) NULL,
	[cnpj] [varchar](20) NULL,
	[nome_fantasia] [varchar](120) NULL,
	[razao_social] [varchar](120) NULL,
	[senha] [varchar](10) NOT NULL,
	[id_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[id_pessoa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fisica]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fisica](
	[cpf] [varchar](14) NOT NULL,
	[nome] [varchar](120) NOT NULL,
	[codigo] [int] NOT NULL,
	[sexo] [varchar](15) NOT NULL,
	[nascimento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[cpf] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[juridica]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[juridica](
	[cnpj] [varchar](20) NOT NULL,
	[nome_fantasia] [varchar](120) NOT NULL,
	[razao_social] [varchar](120) NULL,
	[codigo] [int] NOT NULL,
	[responsavel] [varchar](120) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cnpj] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itenspedidos]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itenspedidos](
	[id_itens] [int] IDENTITY(1,1) NOT NULL,
	[quantidade] [int] NOT NULL,
	[valor_unitario] [real] NOT NULL,
	[id_produto] [int] NOT NULL,
	[codigo_pessoa] [int] NOT NULL,
	[statos] [varchar](1) NULL,
	[data] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_itens] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itens_compra]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itens_compra](
	[id_itens] [int] IDENTITY(1,1) NOT NULL,
	[quantidade] [int] NOT NULL,
	[valor_unidade] [real] NULL,
	[id_produto] [int] NOT NULL,
	[codigo_pessoa] [int] NOT NULL,
	[data] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_itens] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[animal]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[animal](
	[id_animal] [int] IDENTITY(1,1) NOT NULL,
	[peso] [float] NOT NULL,
	[preco] [real] NOT NULL,
	[quantidade] [int] NOT NULL,
	[id_fornecedor] [int] NOT NULL,
	[id_tipo] [int] NOT NULL,
	[recebimento] [varchar](130) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_animal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[compra]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[valor_total] [real] NOT NULL,
	[id_itens] [int] NOT NULL,
	[id_pessoa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entregas]    Script Date: 05/18/2014 13:50:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entregas](
	[id_entrega] [int] IDENTITY(1,1) NOT NULL,
	[cliente] [varchar](200) NOT NULL,
	[data] [varchar](40) NOT NULL,
	[horario] [varchar](20) NOT NULL,
	[id_item] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_entrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__fisica__nascimen__0BC6C43E]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fisica] ADD  DEFAULT (NULL) FOR [nascimento]
GO
/****** Object:  Default [DF__fornecedor__nome__117F9D94]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT (NULL) FOR [nome]
GO
/****** Object:  Default [DF__fornecedor__cnpj__1273C1CD]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT (NULL) FOR [cnpj]
GO
/****** Object:  Default [DF__fornecedo__nome___1367E606]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT (NULL) FOR [nome_fantasia]
GO
/****** Object:  Default [DF__fornecedo__razao__145C0A3F]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT (NULL) FOR [razao_social]
GO
/****** Object:  Default [DF__fornecedo__id_pe__15502E78]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor] ADD  DEFAULT (NULL) FOR [id_pessoa]
GO
/****** Object:  Default [DF__juridica__razao___060DEAE8]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[juridica] ADD  DEFAULT (NULL) FOR [razao_social]
GO
/****** Object:  Default [DF__pessoa__telefone__014935CB]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[pessoa] ADD  DEFAULT (NULL) FOR [telefone]
GO
/****** Object:  ForeignKey [FK__animal__id_forne__1ED998B2]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[fornecedor] ([id_fornecedor])
GO
/****** Object:  ForeignKey [FK__animal__id_tipo__1FCDBCEB]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[animal]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo] ([id_tipo])
GO
/****** Object:  ForeignKey [FK__compra__id_itens__6383C8BA]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[compra]  WITH CHECK ADD FOREIGN KEY([id_itens])
REFERENCES [dbo].[itens_compra] ([id_itens])
GO
/****** Object:  ForeignKey [FK__compra__id_pesso__6477ECF3]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[compra]  WITH CHECK ADD FOREIGN KEY([id_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__entregado__id_pe__7B5B524B]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[entregador]  WITH CHECK ADD FOREIGN KEY([id_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__entregas__id_ite__00200768]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[entregas]  WITH CHECK ADD FOREIGN KEY([id_item])
REFERENCES [dbo].[itenspedidos] ([id_itens])
GO
/****** Object:  ForeignKey [FK__fisica__codigo__0CBAE877]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fisica]  WITH CHECK ADD FOREIGN KEY([codigo])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__fornecedo__id_pe__164452B1]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[fornecedor]  WITH CHECK ADD FOREIGN KEY([id_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__itens_com__codig__6D0D32F4]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[itens_compra]  WITH CHECK ADD FOREIGN KEY([codigo_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__itens_com__id_pr__5AEE82B9]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[itens_compra]  WITH CHECK ADD FOREIGN KEY([id_produto])
REFERENCES [dbo].[produto] ([id_produto])
GO
/****** Object:  ForeignKey [FK__itenspedi__codig__619B8048]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[itenspedidos]  WITH CHECK ADD FOREIGN KEY([codigo_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__itenspedi__id_pr__5FB337D6]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[itenspedidos]  WITH CHECK ADD FOREIGN KEY([id_produto])
REFERENCES [dbo].[produto] ([id_produto])
GO
/****** Object:  ForeignKey [FK__juridica__codigo__07020F21]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[juridica]  WITH CHECK ADD FOREIGN KEY([codigo])
REFERENCES [dbo].[pessoa] ([codigo])
GO
/****** Object:  ForeignKey [FK__produto__id_tipo__5629CD9C]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[produto]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo] ([id_tipo])
GO
/****** Object:  ForeignKey [FK__solicitac__id_pe__693CA210]    Script Date: 05/18/2014 13:50:22 ******/
ALTER TABLE [dbo].[solicitacao]  WITH CHECK ADD FOREIGN KEY([id_pessoa])
REFERENCES [dbo].[pessoa] ([codigo])
GO
