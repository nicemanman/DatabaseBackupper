using System;
using System.Text;
/// <summary>
/// https://stackoverflow.com/a/36476600/2343
/// </summary>
public class Table : IDisposable
{
    private StringBuilder _sb;

    public Table(StringBuilder sb, string id = "default", string classValue = "")
    {
        _sb = sb;
        _sb.Append($"<table border = \"1\" id=\"{id}\" class=\"{classValue}\">");
    }

    public void Dispose()
    {
        _sb.Append("</table>");
    }

    public Row AddRow()
    {
        return new Row(_sb);
    }

    public Row AddHeaderRow()
    {
        return new Row(_sb, true);
    }

    public void StartTableBody()
    {
        _sb.Append("<tbody>");

    }

    public void EndTableBody()
    {
        _sb.Append("</tbody>");

    }
}

public class Row : IDisposable
{
    private StringBuilder _sb;
    private bool _isHeader;
    public Row(StringBuilder sb, bool isHeader = false)
    {
        _sb = sb;
        _isHeader = isHeader;
        if (_isHeader)
        {
            _sb.Append("<thead>");
        }
        _sb.Append("<tr>");
    }

    public void Dispose()
    {
        _sb.Append("</tr>");
        if (_isHeader)
        {
            _sb.Append("</thead>");
        }
    }

    public void AddCell(string innerText)
    {
        _sb.Append("<td>");
        _sb.Append(innerText);
        _sb.Append("</td>");
    }
}
