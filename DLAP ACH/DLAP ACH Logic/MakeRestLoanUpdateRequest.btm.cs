namespace DLAPACHLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHDefinition.ACHRequest", typeof(global::DLAPACHDefinition.ACHRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHSalesforceDefinition.RestLoan+SaveRequest", typeof(global::DLAPACHSalesforceDefinition.RestLoan.SaveRequest))]
    public sealed class MakeRestLoanUpdateRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.gov/DLAPACH/ACHRequestRequest"" xmlns:ns0=""http://SBA.gov/DLAPACH/REST/INSERT/Loan"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ACHRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:ACHRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(achAccountNumber/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringSize(string(achRoutingNumber/text()))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalGt(string($var:v4) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:LogicalEq(string(achAccountType/text()) , &quot;CHECKING&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:LogicalNot(string($var:v7))"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringSize(string(achFinancialInstitution/text()))"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalGt(string($var:v11) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringSize(string(achAccountOwner/text()))"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalGt(string($var:v14) , &quot;0&quot;)"" />
    <ns0:SaveRequest>
      <ns0:allOrNone>
        <xsl:text>true</xsl:text>
      </ns0:allOrNone>
      <ns0:records>
        <xsl:attribute name=""type"">
          <xsl:text>Loan__c</xsl:text>
        </xsl:attribute>
        <ns0:Id>
          <xsl:text />
        </ns0:Id>
        <xsl:if test=""string($var:v2)='true'"">
          <xsl:variable name=""var:v3"" select=""achAccountNumber/text()"" />
          <ns0:ACH_Account_Number__c>
            <xsl:value-of select=""$var:v3"" />
          </ns0:ACH_Account_Number__c>
        </xsl:if>
        <xsl:if test=""string($var:v5)='true'"">
          <xsl:variable name=""var:v6"" select=""achRoutingNumber/text()"" />
          <ns0:ACH_Routing_Number__c>
            <xsl:value-of select=""$var:v6"" />
          </ns0:ACH_Routing_Number__c>
        </xsl:if>
        <xsl:if test=""string($var:v7)='true'"">
          <xsl:variable name=""var:v8"" select=""&quot;Checking&quot;"" />
          <ns0:ACH_Account_Type__c>
            <xsl:value-of select=""$var:v8"" />
          </ns0:ACH_Account_Type__c>
        </xsl:if>
        <xsl:if test=""string($var:v9)='true'"">
          <xsl:variable name=""var:v10"" select=""achAccountType/text()"" />
          <ns0:ACH_Account_Type__c>
            <xsl:value-of select=""$var:v10"" />
          </ns0:ACH_Account_Type__c>
        </xsl:if>
        <xsl:if test=""string($var:v12)='true'"">
          <xsl:variable name=""var:v13"" select=""achFinancialInstitution/text()"" />
          <ns0:Bank_Name__c>
            <xsl:value-of select=""$var:v13"" />
          </ns0:Bank_Name__c>
        </xsl:if>
        <xsl:if test=""string($var:v15)='true'"">
          <xsl:variable name=""var:v16"" select=""achAccountOwner/text()"" />
          <ns0:Account_Holder_Name__c>
            <xsl:value-of select=""$var:v16"" />
          </ns0:Account_Holder_Name__c>
        </xsl:if>
      </ns0:records>
    </ns0:SaveRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DLAPACHDefinition.ACHRequest";
        
        private const global::DLAPACHDefinition.ACHRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPACHSalesforceDefinition.RestLoan+SaveRequest";
        
        private const global::DLAPACHSalesforceDefinition.RestLoan.SaveRequest _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"DLAPACHSalesforceDefinition.RestLoan+SaveRequest";
                return _TrgSchemas;
            }
        }
    }
}
