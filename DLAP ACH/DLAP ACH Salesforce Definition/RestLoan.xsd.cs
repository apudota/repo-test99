namespace DLAPACHSalesforceDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaveRequest", @"results"})]
    public sealed class RestLoan : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SBA.gov/DLAPACH/REST/INSERT/Loan"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SBA.gov/DLAPACH/REST/INSERT/Loan"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SaveRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""true"" name=""allOrNone"" type=""xs:boolean"" />
        <xs:element maxOccurs=""unbounded"" name=""records"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ACH_Account_Number__c"" type=""xs:unsignedLong"" />
              <xs:element minOccurs=""0"" name=""ACH_Routing_Number__c"" type=""xs:unsignedInt"" />
              <xs:element minOccurs=""0"" name=""ACH_Account_Type__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Bank_Name__c"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""Account_Holder_Name__c"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute default=""Loan__c"" name=""type"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""results"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""errors"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""warnings"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""message"" type=""xs:string"" />
                    <xs:element name=""statusCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""id"" type=""xs:string"" />
              <xs:element name=""success"" type=""xs:boolean"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RestLoan() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SaveRequest";
                _RootElements[1] = "results";
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
        
        [Schema(@"http://SBA.gov/DLAPACH/REST/INSERT/Loan",@"SaveRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaveRequest"})]
        public sealed class SaveRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaveRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SaveRequest";
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
        
        [Schema(@"http://SBA.gov/DLAPACH/REST/INSERT/Loan",@"results")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"results"})]
        public sealed class results : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public results() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "results";
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
}
