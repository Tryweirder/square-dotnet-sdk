
# Check Appointments Onboarded Response

## Structure

`CheckAppointmentsOnboardedResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppointmentsOnboarded` | `bool?` | Optional | Indicates whether the seller has enabled the Square Appointments service (`true`) or not (`false`). |
| `Errors` | [`IList<Models.Error>`](/doc/models/error.md) | Optional | Any errors that occurred during the request. |

## Example (as JSON)

```json
{
  "appointments_onboarded": false,
  "errors": [
    {
      "category": "AUTHENTICATION_ERROR",
      "code": "VALUE_TOO_SHORT",
      "detail": "detail1",
      "field": "field9"
    },
    {
      "category": "INVALID_REQUEST_ERROR",
      "code": "VALUE_TOO_LONG",
      "detail": "detail2",
      "field": "field0"
    },
    {
      "category": "RATE_LIMIT_ERROR",
      "code": "VALUE_TOO_LOW",
      "detail": "detail3",
      "field": "field1"
    }
  ]
}
```

