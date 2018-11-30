namespace DLAPACHLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHDefinition.ACHRequest", typeof(global::DLAPACHDefinition.ACHRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHSalesforceDefinition.RestLoanQuery+Request", typeof(global::DLAPACHSalesforceDefinition.RestLoanQuery.Request))]
    public sealed class MakeUpdateLoanRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPACH/ACHRequestRequest"" xmlns:ns0=""http://SBA.gov/DLAPACH/REST/QUERY/Loan"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ACHRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:ACHRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(LoanName))"" />
    <ns0:Request>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""LoanName/text()"" />
        <ns0:SOQL_Loan_Query>
          <xsl:value-of select=""$var:v2"" />
        </ns0:SOQL_Loan_Query>
      </xsl:if>
    </ns0:Request>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPACHDefinition.ACHRequest";
        
        private const global::DLAPACHDefinition.ACHRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPACHSalesforceDefinition.RestLoanQuery+Request";
        
        private const global::DLAPACHSalesforceDefinition.RestLoanQuery.Request _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"DLAPACHDefinition.ACHRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPACHSalesforceDefinition.RestLoanQuery+Request";
                return _TrgSchemas;
            }
        }
    }
}
