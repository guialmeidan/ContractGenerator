using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Migrations 
{
    [Migration(201810211238)]
    public class _201810211238_Criar_Approved : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Approved")
                    .WithColumn("Id").AsInt32().PrimaryKey()
                    .WithColumn("IdEP").AsInt32()
                    .WithColumn("NomeEP").AsString(200)
                    .WithColumn("IdResponsavel").AsInt32().Nullable()
                    .WithColumn("NomeResponsavel").AsString(200).Nullable()
                    .WithColumn("EPID").AsString(20).Nullable()
                    .WithColumn("IdPresidente").AsInt32()
                    .WithColumn("TipoProdutoId").AsInt32()
                    .WithColumn("TipoProdutoDescricao").AsString(200)
                    .WithColumn("TNID").AsString(20)
                    .WithColumn("PaisDestino").AsString(200)
                    .WithColumn("CidadeDestino").AsString(200)
                    .WithColumn("DataInicio").AsDateTime()
                    .WithColumn("DataFim").AsDateTime()
                    .WithColumn("CargaHorariaNumeral").AsInt32()
                    .WithColumn("CargaHorariaExtenso").AsString(200)
                    .WithColumn("TrabalhoSabado").AsString(20)
                    .WithColumn("TaxaDestino").AsString(200)
                    .WithColumn("BolsaAuxilio").AsString(200)
                    .WithColumn("AcomodacaoProvida").AsString(20)
                    .WithColumn("AcomodacaoCoberta").AsString(20)
                    .WithColumn("AlimentacaoDiaTrabalho").AsString(200)
                    .WithColumn("AlimentacaoFimSemana").AsString(200)
                    .WithColumn("Computador").AsString(20)
                    .WithColumn("DataApproved").AsDateTime()
                    .WithColumn("ValorContratoNumerico").AsDecimal()
                    .WithColumn("ValorContratoExtenso").AsString(200)
                    .WithColumn("DataPagamento").AsDateTime()
                    .WithColumn("TipoPagamento").AsInt32()
                    .WithColumn("QtdParcelas").AsInt32().Nullable()
                    .WithColumn("ValorParcialNumerico").AsDecimal()
                    .WithColumn("ValorParcialExtenso").AsString(200)
                    .WithColumn("ModoBoleto").AsBoolean().Nullable()
                    .WithColumn("ModoCartaoCredito").AsBoolean().Nullable()
                    .WithColumn("ModoCartaoDebito").AsBoolean().Nullable()
                    .WithColumn("ModoCheque").AsBoolean().Nullable()
                    .WithColumn("ModoDeposito").AsBoolean().Nullable()
                    .WithColumn("ModoDinheiro").AsBoolean().Nullable()
                    .WithColumn("ModoPagSeguro").AsBoolean().Nullable()
                    .WithColumn("ModoTransferencia").AsBoolean().Nullable()
                    .WithColumn("IdTestemunha1").AsInt32()
                    .WithColumn("NomeTestemunha1").AsString(200)
                    .WithColumn("IdTestemunha2").AsInt32()
                    .WithColumn("NomeTestemunha2").AsString(200);
        }
    }
}