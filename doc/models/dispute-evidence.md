
# Dispute Evidence

## Structure

`DisputeEvidence`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EvidenceId` | `string` | Optional | The Square-generated ID of the evidence.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `40` |
| `DisputeId` | `string` | Optional | The ID of the dispute the evidence is associated with.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `40` |
| `UploadedAt` | `string` | Optional | The time when the next action is due, in RFC 3339 format.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `40` |
| `EvidenceType` | [`string`](/doc/models/dispute-evidence-type.md) | Optional | The type of the dispute evidence. |

## Example (as JSON)

```json
{
  "evidence_id": "evidence_id2",
  "dispute_id": "dispute_id2",
  "uploaded_at": "uploaded_at4",
  "evidence_type": "RECEIPT"
}
```

