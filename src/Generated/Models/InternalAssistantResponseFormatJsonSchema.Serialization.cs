// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI.Internal;

namespace OpenAI.Assistants
{
    internal partial class InternalAssistantResponseFormatJsonSchema : IJsonModel<InternalAssistantResponseFormatJsonSchema>
    {
        void IJsonModel<InternalAssistantResponseFormatJsonSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantResponseFormatJsonSchema)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("json_schema") != true)
            {
                writer.WritePropertyName("json_schema"u8);
                writer.WriteObjectValue(JsonSchema, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalAssistantResponseFormatJsonSchema IJsonModel<InternalAssistantResponseFormatJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantResponseFormatJsonSchema)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAssistantResponseFormatJsonSchema(document.RootElement, options);
        }

        internal static InternalAssistantResponseFormatJsonSchema DeserializeInternalAssistantResponseFormatJsonSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponseFormatJsonSchemaJsonSchema jsonSchema = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("json_schema"u8))
                {
                    jsonSchema = InternalResponseFormatJsonSchemaJsonSchema.DeserializeInternalResponseFormatJsonSchemaJsonSchema(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalAssistantResponseFormatJsonSchema(type, serializedAdditionalRawData, jsonSchema);
        }

        BinaryData IPersistableModel<InternalAssistantResponseFormatJsonSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantResponseFormatJsonSchema)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAssistantResponseFormatJsonSchema IPersistableModel<InternalAssistantResponseFormatJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalAssistantResponseFormatJsonSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantResponseFormatJsonSchema)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAssistantResponseFormatJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}