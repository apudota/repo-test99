namespace DLAPACHDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SBA.gov/DLAPACH/ACHRequestRequest",@"ACHRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LoanName", XPath = @"/*[local-name()='ACHRequest' and namespace-uri()='http://SBA.gov/DLAPACH/ACHRequestRequest']/*[local-name()='LoanName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ACHRequest"})]
    public sealed class ACHRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPACH/ACHRequestRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SBA.gov/DLAPACH/ACHRequestRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ACHRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ACHRequest' and namespace-uri()='http://SBA.gov/DLAPACH/ACHRequestRequest']/*[local-name()='LoanName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LoanName"" type=""xs:string"" />
        <xs:element name=""UserID"" type=""xs:string"" />
        <xs:element name=""achRoutingNumber"" type=""xs:string"" />
        <xs:element name=""achAccountNumber"" type=""xs:string"" />
        <xs:element name=""achAccountType"" type=""xs:string"" />
        <xs:element name=""achAccountOwner"" type=""xs:string"" />
        <xs:element name=""achFinancialInstitution"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ACHRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ACHRequest";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
