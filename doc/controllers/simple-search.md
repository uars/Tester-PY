# Simple Search

```csharp
SimpleSearchController simpleSearchController = client.SimpleSearchController;
```

## Class Name

`SimpleSearchController`


# Do Search

```csharp
DoSearchAsync(
    Models.TypeSearchEnum type,
    string part,
    int maxResults,
    string key,
    string q)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`Models.TypeSearchEnum`](/doc/models/type-search-enum.md) | Template, Required | - |
| `part` | `string` | Query, Required | - |
| `maxResults` | `int` | Query, Required | - |
| `key` | `string` | Query, Required | API-Key |
| `q` | `string` | Query, Required | keyword |

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
TypeSearchEnum type = TypeSearchEnum.Search;
string part = "snippet";
int maxResults = 25;
string key = "AIzaSyAzYmRVV7HvVqh6OcNgbB4AC8NcjyXJBR4";
string q = "surfing";

try
{
    dynamic result = await simpleSearchController.DoSearchAsync(type, part, maxResults, key, q);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The channelId parameter specified an invalid channel ID | [`InvalidChannelIdException`](/doc/models/invalid-channel-id-exception.md) |
| 402 | The relatedToVideo parameter specified an invalid video ID | [`InvalidVideoIdException`](/doc/models/invalid-video-id-exception.md) |

