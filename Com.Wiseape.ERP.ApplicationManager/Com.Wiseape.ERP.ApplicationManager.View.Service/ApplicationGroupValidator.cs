using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.Utility;
using AspCompiler;
using Com.Wiseape.UtilityApp.CodeGenerator.Helper;
public class Page {
  public MyStreamWriter me;
  public MyStreamWriter Response;
  public string SectionText0;
  public string SectionText2;
  public string SectionText4;
  public string SectionText6;
  public string SectionText8;
  public string SectionText10;
  public string SectionText12;
  public string SectionText14;
  public string SectionText16;
  public string SectionText18;
  public string SectionText20;
  public string SectionText22;
  public string SectionText24;
  public string SectionText26;
  public string SectionText28;
  public string SectionText30;
  public string SectionText32;
  public string SectionText34;
  public string SectionText36;
  public string SectionText38;
  public string SectionText40;
  public string SectionText42;
  public string SectionText44;
  public string SectionText46;
  public string SectionText48;
  public string SectionText50;
  public string SectionText52;
  public string SectionText54;
  public string SectionText56;
  public string SectionText58;
  public string SectionText60;
  public string SectionText62;
  public string SectionText64;
  public string SectionText66;
  public string SectionText68;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorProject Project;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorModule Module;
  public Page() {}
  public void RenderPage() {
    me.say(SectionText0);
 me.say(Project.CompanyName);     me.say(SectionText2);
 me.say(Project.ProjectName);     me.say(SectionText4);
 me.say(Module.ModuleName);     me.say(SectionText6);

	DataSourceTable table = (DataSourceTable)Module.Datasource;
	string tableName = table.TableName;
	string keyColumnName = table.KeyColumn.ColumnName;
	string keyColumnVar = StrUtil.LowFirst(keyColumnName);
	
	DataSourceValidationTable uiTable = (DataSourceValidationTable)Module.ModelType.Datasource;
    me.say(SectionText8);
 me.say(Project.CompanyName);     me.say(SectionText10);
 me.say(Project.ProjectName);     me.say(SectionText12);
 me.say(Module.ModuleName);     me.say(SectionText14);
 me.say(tableName);     me.say(SectionText16);
 me.say(tableName);     me.say(SectionText18);
 me.say(tableName);     me.say(SectionText20);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText22);
 me.say(tableName);     me.say(SectionText24);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText26);
 me.say(column.ColumnName);     me.say(SectionText28);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText30);
 me.say(column.ColumnName);     me.say(SectionText32);

	}
}
    me.say(SectionText34);
 me.say(tableName);     me.say(SectionText36);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText38);
 me.say(tableName);     me.say(SectionText40);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText42);
 me.say(column.ColumnName);     me.say(SectionText44);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText46);
 me.say(column.ColumnName);     me.say(SectionText48);

	}
}
    me.say(SectionText50);

foreach(ValidatorColumn column in uiTable.DataColumns)
{

    me.say(SectionText52);
 me.say(column.ColumnName);     me.say(SectionText54);
 me.say(DatabaseMapper.MapType( column.DataType ));     me.say(SectionText56);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText58);

	if(column.Use)
	{
    me.say(SectionText60);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText62);
 me.say(StrUtil.SplitCamelCase( column.ColumnName));     me.say(SectionText64);

	}
    me.say(SectionText66);

	}
}
    me.say(SectionText68);
  }
}
Error on line 122: Invalid token '(' in class, struct, or interface member declarationusing System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.Utility;
using AspCompiler;
using Com.Wiseape.UtilityApp.CodeGenerator.Helper;
public class Page {
  public MyStreamWriter me;
  public MyStreamWriter Response;
  public string SectionText0;
  public string SectionText2;
  public string SectionText4;
  public string SectionText6;
  public string SectionText8;
  public string SectionText10;
  public string SectionText12;
  public string SectionText14;
  public string SectionText16;
  public string SectionText18;
  public string SectionText20;
  public string SectionText22;
  public string SectionText24;
  public string SectionText26;
  public string SectionText28;
  public string SectionText30;
  public string SectionText32;
  public string SectionText34;
  public string SectionText36;
  public string SectionText38;
  public string SectionText40;
  public string SectionText42;
  public string SectionText44;
  public string SectionText46;
  public string SectionText48;
  public string SectionText50;
  public string SectionText52;
  public string SectionText54;
  public string SectionText56;
  public string SectionText58;
  public string SectionText60;
  public string SectionText62;
  public string SectionText64;
  public string SectionText66;
  public string SectionText68;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorProject Project;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorModule Module;
  public Page() {}
  public void RenderPage() {
    me.say(SectionText0);
 me.say(Project.CompanyName);     me.say(SectionText2);
 me.say(Project.ProjectName);     me.say(SectionText4);
 me.say(Module.ModuleName);     me.say(SectionText6);

	DataSourceTable table = (DataSourceTable)Module.Datasource;
	string tableName = table.TableName;
	string keyColumnName = table.KeyColumn.ColumnName;
	string keyColumnVar = StrUtil.LowFirst(keyColumnName);
	
	DataSourceValidationTable uiTable = (DataSourceValidationTable)Module.ModelType.Datasource;
    me.say(SectionText8);
 me.say(Project.CompanyName);     me.say(SectionText10);
 me.say(Project.ProjectName);     me.say(SectionText12);
 me.say(Module.ModuleName);     me.say(SectionText14);
 me.say(tableName);     me.say(SectionText16);
 me.say(tableName);     me.say(SectionText18);
 me.say(tableName);     me.say(SectionText20);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText22);
 me.say(tableName);     me.say(SectionText24);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText26);
 me.say(column.ColumnName);     me.say(SectionText28);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText30);
 me.say(column.ColumnName);     me.say(SectionText32);

	}
}
    me.say(SectionText34);
 me.say(tableName);     me.say(SectionText36);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText38);
 me.say(tableName);     me.say(SectionText40);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText42);
 me.say(column.ColumnName);     me.say(SectionText44);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText46);
 me.say(column.ColumnName);     me.say(SectionText48);

	}
}
    me.say(SectionText50);

foreach(ValidatorColumn column in uiTable.DataColumns)
{

    me.say(SectionText52);
 me.say(column.ColumnName);     me.say(SectionText54);
 me.say(DatabaseMapper.MapType( column.DataType ));     me.say(SectionText56);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText58);

	if(column.Use)
	{
    me.say(SectionText60);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText62);
 me.say(StrUtil.SplitCamelCase( column.ColumnName));     me.say(SectionText64);

	}
    me.say(SectionText66);

	}
}
    me.say(SectionText68);
  }
}
Error on line 122: Invalid token ')' in class, struct, or interface member declarationusing System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections;
using Com.Wiseape.UtilityApp.CodeGenerator.Model;
using Com.Wiseape.UtilityApp.CodeGenerator.Business;
using Com.Wiseape.Utility;
using AspCompiler;
using Com.Wiseape.UtilityApp.CodeGenerator.Helper;
public class Page {
  public MyStreamWriter me;
  public MyStreamWriter Response;
  public string SectionText0;
  public string SectionText2;
  public string SectionText4;
  public string SectionText6;
  public string SectionText8;
  public string SectionText10;
  public string SectionText12;
  public string SectionText14;
  public string SectionText16;
  public string SectionText18;
  public string SectionText20;
  public string SectionText22;
  public string SectionText24;
  public string SectionText26;
  public string SectionText28;
  public string SectionText30;
  public string SectionText32;
  public string SectionText34;
  public string SectionText36;
  public string SectionText38;
  public string SectionText40;
  public string SectionText42;
  public string SectionText44;
  public string SectionText46;
  public string SectionText48;
  public string SectionText50;
  public string SectionText52;
  public string SectionText54;
  public string SectionText56;
  public string SectionText58;
  public string SectionText60;
  public string SectionText62;
  public string SectionText64;
  public string SectionText66;
  public string SectionText68;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorProject Project;
  public Com.Wiseape.UtilityApp.CodeGenerator.Model.CodeGeneratorModule Module;
  public Page() {}
  public void RenderPage() {
    me.say(SectionText0);
 me.say(Project.CompanyName);     me.say(SectionText2);
 me.say(Project.ProjectName);     me.say(SectionText4);
 me.say(Module.ModuleName);     me.say(SectionText6);

	DataSourceTable table = (DataSourceTable)Module.Datasource;
	string tableName = table.TableName;
	string keyColumnName = table.KeyColumn.ColumnName;
	string keyColumnVar = StrUtil.LowFirst(keyColumnName);
	
	DataSourceValidationTable uiTable = (DataSourceValidationTable)Module.ModelType.Datasource;
    me.say(SectionText8);
 me.say(Project.CompanyName);     me.say(SectionText10);
 me.say(Project.ProjectName);     me.say(SectionText12);
 me.say(Module.ModuleName);     me.say(SectionText14);
 me.say(tableName);     me.say(SectionText16);
 me.say(tableName);     me.say(SectionText18);
 me.say(tableName);     me.say(SectionText20);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText22);
 me.say(tableName);     me.say(SectionText24);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText26);
 me.say(column.ColumnName);     me.say(SectionText28);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText30);
 me.say(column.ColumnName);     me.say(SectionText32);

	}
}
    me.say(SectionText34);
 me.say(tableName);     me.say(SectionText36);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText38);
 me.say(tableName);     me.say(SectionText40);

foreach(ValidatorColumn column in uiTable.DataColumns)
{
	if(column.Use)
	{
    me.say(SectionText42);
 me.say(column.ColumnName);     me.say(SectionText44);
 me.say(StrUtil.LowFirst(tableName));     me.say(SectionText46);
 me.say(column.ColumnName);     me.say(SectionText48);

	}
}
    me.say(SectionText50);

foreach(ValidatorColumn column in uiTable.DataColumns)
{

    me.say(SectionText52);
 me.say(column.ColumnName);     me.say(SectionText54);
 me.say(DatabaseMapper.MapType( column.DataType ));     me.say(SectionText56);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText58);

	if(column.Use)
	{
    me.say(SectionText60);
 me.say(StrUtil.LowFirst(column.ColumnName));     me.say(SectionText62);
 me.say(StrUtil.SplitCamelCase( column.ColumnName));     me.say(SectionText64);

	}
    me.say(SectionText66);

	}
}
    me.say(SectionText68);
  }
}
Error on line 124: Type or namespace definition, or end-of-file expected