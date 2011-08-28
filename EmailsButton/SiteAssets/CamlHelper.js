
/// <reference name="MicrosoftAjax.js" /> 
/// <reference path="file://C:/Program Files/Common Files/Microsoft Shared/Web Server Extensions/14/TEMPLATE/LAYOUTS/SP.core.debug.js" />
/// <reference path="file://C:/Program Files/Common Files/Microsoft Shared/Web Server Extensions/14/TEMPLATE/LAYOUTS/SP.debug.js" />

function getSelectedItemsQuery() {
    /// <summary>
    /// This function returns string which contains CAML query for retrieving all selected list items
    /// </summary>
    var sb = new Sys.StringBuilder();
    var writer = new SP.XmlWriter.create(sb);

    writer.writeStartElement("Where");

    var items = SP.ListOperation.Selection.getSelectedItems();
    var itemsCount = items.length;
    while (items.length > 1) {
        writer.writeStartElement("Or");
        writeEqStatement(writer, "ID", "Integer", items.pop().id);
    }

    writeEqStatement(writer, "ID", "Integer", items.pop().id);

    while (itemsCount > 1) {
        itemsCount--;
        writer.writeEndElement();
    }

    writer.writeEndElement();
    writer.close();

    return sb.toString();
}

function writeEqStatement(writer, fieldName, valueType, value) {
    /// <summary>
    /// This function adds to passed writer the Eq Caml statement:
    /// '<Eq><FieldRef Name="{fieldName}" /><Value Type="{valueType}">{value}</Value></Eq>'
    /// </summary>

    writer.writeStartElement("Eq");

    writer.writeStartElement("FieldRef");
    writer.writeAttributeString("Name", fieldName);
    writer.writeEndElement();

    writer.writeStartElement("Value");
    writer.writeAttributeString("Type", valueType);
    writer.writeString(value);
    writer.writeEndElement();

    writer.writeEndElement();
}

