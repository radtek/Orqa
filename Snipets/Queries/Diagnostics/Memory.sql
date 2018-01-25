-- Memory.sql

select ':::::::::::::::::::::::::::::::::: PROGRAM GLOBAL AREA statistics :::::::::::::::::::::::::::::::::' from dual;
SELECT to_char(ssn.sid, '9999') || ' - ' || nvl(ssn.username, nvl(bgp.name, 'background')) ||
               nvl(lower(ssn.machine), ins.host_name) "SESSION",
       to_char(prc.spid, '999999999') "PID/THREAD",
       to_char((se1.value/1024)/1024, '999G999G990D00') || ' MB' "CURRENT SIZE",
       to_char((se2.value/1024)/1024, '999G999G990D00') || ' MB' "MAXIMUM SIZE"
  FROM v$sesstat se1, v$sesstat se2, v$session ssn, v$bgprocess bgp, v$process prc,
       v$instance ins,  v$statname stat1, v$statname stat2
 WHERE se1.statistic# = stat1.statistic# AND stat1.name = 'session pga memory'
   AND se2.statistic# = stat2.statistic# AND stat2.name = 'session pga memory max'
   AND se1.sid        = ssn.sid
   AND se2.sid        = ssn.sid
   AND ssn.paddr      = bgp.paddr (+)
   AND ssn.paddr      = prc.addr  (+)
 ORDER BY 3 DESC;

select ':::::::::::::::::::::::::::::::::::: USER GLOBAL AREA statistics ::::::::::::::::::::::::::::::::::' from dual;
SELECT to_char(ssn.sid, '9999') || ' - ' || nvl(ssn.username, nvl(bgp.name, 'background')) ||
               nvl(lower(ssn.machine), ins.host_name) "SESSION",
       to_char(prc.spid, '999999999') "PID/THREAD",
       to_char((se1.value/1024)/1024, '999G999G990D00') || ' MB' "CURRENT SIZE",
       to_char((se2.value/1024)/1024, '999G999G990D00') || ' MB' "MAXIMUM SIZE"
  FROM v$sesstat se1, v$sesstat se2, v$session ssn, v$bgprocess bgp, v$process prc,
       v$instance ins,  v$statname stat1, v$statname stat2
 WHERE se1.statistic# = stat1.statistic# AND stat1.name = 'session uga memory'
   AND se2.statistic# = stat2.statistic# AND stat2.name = 'session uga memory max'
   AND se1.sid        = ssn.sid
   AND se2.sid        = ssn.sid
   AND ssn.paddr      = bgp.paddr (+)
   AND ssn.paddr      = prc.addr  (+)
 ORDER BY 3 DESC;