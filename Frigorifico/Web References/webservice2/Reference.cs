﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18063.
// 
#pragma warning disable 1591

namespace Frigorifico.webservice2 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Pessoa))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tipo))]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback solicitacaoListaFisicaOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateStatuOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertEntregaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::Frigorifico.Properties.Settings.Default.Frigorifico_webservice2_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event solicitacaoListaFisicaCompletedEventHandler solicitacaoListaFisicaCompleted;
        
        /// <remarks/>
        public event updateStatuCompletedEventHandler updateStatuCompleted;
        
        /// <remarks/>
        public event insertEntregaCompletedEventHandler insertEntregaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/solicitacaoListaFisica", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Item_Pedido[] solicitacaoListaFisica() {
            object[] results = this.Invoke("solicitacaoListaFisica", new object[0]);
            return ((Item_Pedido[])(results[0]));
        }
        
        /// <remarks/>
        public void solicitacaoListaFisicaAsync() {
            this.solicitacaoListaFisicaAsync(null);
        }
        
        /// <remarks/>
        public void solicitacaoListaFisicaAsync(object userState) {
            if ((this.solicitacaoListaFisicaOperationCompleted == null)) {
                this.solicitacaoListaFisicaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitacaoListaFisicaOperationCompleted);
            }
            this.InvokeAsync("solicitacaoListaFisica", new object[0], this.solicitacaoListaFisicaOperationCompleted, userState);
        }
        
        private void OnsolicitacaoListaFisicaOperationCompleted(object arg) {
            if ((this.solicitacaoListaFisicaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitacaoListaFisicaCompleted(this, new solicitacaoListaFisicaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateStatu", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateStatu(int iditen) {
            this.Invoke("updateStatu", new object[] {
                        iditen});
        }
        
        /// <remarks/>
        public void updateStatuAsync(int iditen) {
            this.updateStatuAsync(iditen, null);
        }
        
        /// <remarks/>
        public void updateStatuAsync(int iditen, object userState) {
            if ((this.updateStatuOperationCompleted == null)) {
                this.updateStatuOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateStatuOperationCompleted);
            }
            this.InvokeAsync("updateStatu", new object[] {
                        iditen}, this.updateStatuOperationCompleted, userState);
        }
        
        private void OnupdateStatuOperationCompleted(object arg) {
            if ((this.updateStatuCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateStatuCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertEntrega", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void insertEntrega(Entrega ent) {
            this.Invoke("insertEntrega", new object[] {
                        ent});
        }
        
        /// <remarks/>
        public void insertEntregaAsync(Entrega ent) {
            this.insertEntregaAsync(ent, null);
        }
        
        /// <remarks/>
        public void insertEntregaAsync(Entrega ent, object userState) {
            if ((this.insertEntregaOperationCompleted == null)) {
                this.insertEntregaOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertEntregaOperationCompleted);
            }
            this.InvokeAsync("insertEntrega", new object[] {
                        ent}, this.insertEntregaOperationCompleted, userState);
        }
        
        private void OninsertEntregaOperationCompleted(object arg) {
            if ((this.insertEntregaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertEntregaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Item_Pedido {
        
        private int codigoField;
        
        private int qantidadeField;
        
        private double valor_unitarioField;
        
        private string statusField;
        
        private string dataField;
        
        private Produto produtoField;
        
        private Fisica fiscaField;
        
        private Juridica juridicaField;
        
        /// <remarks/>
        public int codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public int qantidade {
            get {
                return this.qantidadeField;
            }
            set {
                this.qantidadeField = value;
            }
        }
        
        /// <remarks/>
        public double valor_unitario {
            get {
                return this.valor_unitarioField;
            }
            set {
                this.valor_unitarioField = value;
            }
        }
        
        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public Produto Produto {
            get {
                return this.produtoField;
            }
            set {
                this.produtoField = value;
            }
        }
        
        /// <remarks/>
        public Fisica fisca {
            get {
                return this.fiscaField;
            }
            set {
                this.fiscaField = value;
            }
        }
        
        /// <remarks/>
        public Juridica juridica {
            get {
                return this.juridicaField;
            }
            set {
                this.juridicaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Produto : Tipo {
        
        private double precoField;
        
        private float pesoField;
        
        private string nome_produtoField;
        
        private int codigo_produto_Field;
        
        /// <remarks/>
        public double preco {
            get {
                return this.precoField;
            }
            set {
                this.precoField = value;
            }
        }
        
        /// <remarks/>
        public float peso {
            get {
                return this.pesoField;
            }
            set {
                this.pesoField = value;
            }
        }
        
        /// <remarks/>
        public string nome_produto {
            get {
                return this.nome_produtoField;
            }
            set {
                this.nome_produtoField = value;
            }
        }
        
        /// <remarks/>
        public int Codigo_produto_ {
            get {
                return this.codigo_produto_Field;
            }
            set {
                this.codigo_produto_Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Produto))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Tipo {
        
        private int codigo_tipoField;
        
        private string nomeField;
        
        /// <remarks/>
        public int codigo_tipo {
            get {
                return this.codigo_tipoField;
            }
            set {
                this.codigo_tipoField = value;
            }
        }
        
        /// <remarks/>
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Entrega {
        
        private string nomeField;
        
        private System.DateTime data_entregaField;
        
        private System.DateTime horario_entregaField;
        
        private Item_Pedido item_pedidoField;
        
        private int codigo_entregaField;
        
        /// <remarks/>
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime data_entrega {
            get {
                return this.data_entregaField;
            }
            set {
                this.data_entregaField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime horario_entrega {
            get {
                return this.horario_entregaField;
            }
            set {
                this.horario_entregaField = value;
            }
        }
        
        /// <remarks/>
        public Item_Pedido item_pedido {
            get {
                return this.item_pedidoField;
            }
            set {
                this.item_pedidoField = value;
            }
        }
        
        /// <remarks/>
        public int Codigo_entrega {
            get {
                return this.codigo_entregaField;
            }
            set {
                this.codigo_entregaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Juridica))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Fisica))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Pessoa {
        
        private string telefoneField;
        
        private string celularField;
        
        private string mailField;
        
        private string enderecoField;
        
        private string estadoField;
        
        private string cepField;
        
        private string municipioField;
        
        private string logradouroField;
        
        private string complementoField;
        
        private int numeroField;
        
        private int codigo_pessoaField;
        
        private string senhaField;
        
        /// <remarks/>
        public string telefone {
            get {
                return this.telefoneField;
            }
            set {
                this.telefoneField = value;
            }
        }
        
        /// <remarks/>
        public string celular {
            get {
                return this.celularField;
            }
            set {
                this.celularField = value;
            }
        }
        
        /// <remarks/>
        public string mail {
            get {
                return this.mailField;
            }
            set {
                this.mailField = value;
            }
        }
        
        /// <remarks/>
        public string endereco {
            get {
                return this.enderecoField;
            }
            set {
                this.enderecoField = value;
            }
        }
        
        /// <remarks/>
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        public string cep {
            get {
                return this.cepField;
            }
            set {
                this.cepField = value;
            }
        }
        
        /// <remarks/>
        public string municipio {
            get {
                return this.municipioField;
            }
            set {
                this.municipioField = value;
            }
        }
        
        /// <remarks/>
        public string logradouro {
            get {
                return this.logradouroField;
            }
            set {
                this.logradouroField = value;
            }
        }
        
        /// <remarks/>
        public string complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
            }
        }
        
        /// <remarks/>
        public int numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        public int Codigo_pessoa {
            get {
                return this.codigo_pessoaField;
            }
            set {
                this.codigo_pessoaField = value;
            }
        }
        
        /// <remarks/>
        public string Senha {
            get {
                return this.senhaField;
            }
            set {
                this.senhaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Juridica : Pessoa {
        
        private string nome_fantasiaField;
        
        private string razao_socialField;
        
        private string responsavelField;
        
        private string cnpjField;
        
        /// <remarks/>
        public string nome_fantasia {
            get {
                return this.nome_fantasiaField;
            }
            set {
                this.nome_fantasiaField = value;
            }
        }
        
        /// <remarks/>
        public string razao_social {
            get {
                return this.razao_socialField;
            }
            set {
                this.razao_socialField = value;
            }
        }
        
        /// <remarks/>
        public string responsavel {
            get {
                return this.responsavelField;
            }
            set {
                this.responsavelField = value;
            }
        }
        
        /// <remarks/>
        public string Cnpj {
            get {
                return this.cnpjField;
            }
            set {
                this.cnpjField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Fisica : Pessoa {
        
        private string nomeField;
        
        private string sexoField;
        
        private string nascimentoField;
        
        private string cpfField;
        
        /// <remarks/>
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string sexo {
            get {
                return this.sexoField;
            }
            set {
                this.sexoField = value;
            }
        }
        
        /// <remarks/>
        public string nascimento {
            get {
                return this.nascimentoField;
            }
            set {
                this.nascimentoField = value;
            }
        }
        
        /// <remarks/>
        public string Cpf {
            get {
                return this.cpfField;
            }
            set {
                this.cpfField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void solicitacaoListaFisicaCompletedEventHandler(object sender, solicitacaoListaFisicaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class solicitacaoListaFisicaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal solicitacaoListaFisicaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Item_Pedido[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Item_Pedido[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void updateStatuCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void insertEntregaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591