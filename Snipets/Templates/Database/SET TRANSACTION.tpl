
SET TRANSACTION
{ { READ { ONLY | WRITE }
  | ISOLATION LEVEL { SERIALIZABLE | READ COMMITTED }
  | USE ROLLBACK SEGMENT rollback_segment
  }
  [NAME 'test']
| NAME 'test'
}
;

