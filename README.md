# NAVReaderWebApp
## How to add ODataV4 connector
- install Microsoft OData CLient using NuGet console
  <pre>Install-Package Microsoft.OData.Client</pre>
- configure template; in case of NAV, it should be enough to add metadata link:
  <pre>public const string MetadataDocumentUri = "http://local:7048/DynamicsNAV100/ODataV4/$metadata";</pre>
