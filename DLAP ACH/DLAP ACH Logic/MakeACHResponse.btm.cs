namespace DLAPACHLogic {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHSalesforceDefinition.RestLoan+results", typeof(global::DLAPACHSalesforceDefinition.RestLoan.results))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DLAPACHDefinition.ACHResponse", typeof(global::DLAPACHDefinition.ACHResponse))]
    public sealed class MakeACHResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://SBA.gov/DLAPACH/ACHResponse"" xmlns:s0=""http://SBA.gov/DLAPACH/REST/INSERT/Loan"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:results"" />
  </xsl:template>
  <xsl:template match=""/s0:results"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(s0:result/s0:id/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;2&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNot(string($var:v2))"" />
    <ns0:ACHResponse>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v3"" select=""&quot;Success&quot;"" />
        <ACK>
          <xsl:value-of select=""$var:v3"" />
        </ACK>
      </xsl:if>
      <xsl:if test=""string($var:v4)='true'"">
        <xsl:variable name=""var:v5"" select=""&quot;Error&quot;"" />
        <ACK>
          <xsl:value-of select=""$var:v5"" />
        </ACK>
      </xsl:if>
    </ns0:ACHResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


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
        
        private const string _strSrcSchemasList0 = @"DLAPACHSalesforceDefinition.RestLoan+results";
        
        private const global::DLAPACHSalesforceDefinition.RestLoan.results _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DLAPACHDefinition.ACHResponse";
        
        private const global::DLAPACHDefinition.ACHResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DLAPACHSalesforceDefinition.RestLoan+results";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DLAPACHDefinition.ACHResponse";
                return _TrgSchemas;
            }
        }
    }
}
