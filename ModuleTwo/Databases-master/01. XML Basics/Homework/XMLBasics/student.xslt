<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:student="student"
    xmlns:exam="exam"                
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <html>
      <body>
        <table bgcolor="#E0E0E0"  cellspacing="1">
          <xsl:for-each select="/student:students/student:student">
            <tr bgcolor="#EEEEEE">
              <td>
                <xsl:value-of select="student:name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:sex"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:birth-date"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:phone"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:email"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:course"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:specialty"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:faculty-number"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:enrollment-date"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="student:enrollment-exam-score"></xsl:value-of>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
