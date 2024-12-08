-- Scripts for updating the database based on planned changes to WC2025.
--
-- docker exec -i database mysql wca_development < ~/wc2025_setup.sql

DELETE FROM registration_competition_events WHERE registration_id IN (SELECT DISTINCT id FROM registrations WHERE competition_id="WC2025");

CREATE TEMPORARY TABLE qualifications
SELECT personId, eventId FROM
(SELECT * FROM RanksAverage WHERE eventId NOT LIKE "%bf" UNION ALL SELECT * FROM RanksSingle WHERE eventId LIKE "%bf") AS r
WHERE (eventId="333" AND best < 6000) OR
(eventId="222" AND best < 3000) OR
(eventId="444" AND best < 6000) OR
(eventId="555" AND best < 9000) OR
(eventId="666" AND best < 16000) OR
(eventId="777" AND best < 24000) OR
(eventId="333bf" AND best < 12000) OR
(eventId="333fm" AND best < 2433) OR
(eventId="333oh" AND best < 3000) OR
(eventId="clock" AND best < 1300) OR
(eventId="minx" AND best < 9000) OR
(eventId="pyram" AND best < 3000) OR
(eventId="skewb" AND best < 3000) OR
(eventId="sq1" AND best < 2500) OR
(eventId="444bf" AND best < 48000) OR
(eventId="555bf" AND best < 60000) OR
(eventId="333mbf" AND best < 770000000);

INSERT INTO registration_competition_events (registration_id, competition_event_id)
SELECT registrations.id, competition_events.id FROM registrations
JOIN users ON registrations.user_id = users.id
JOIN qualifications ON users.wca_id = qualifications.personId
JOIN competition_events ON qualifications.eventId = competition_events.event_id
WHERE registrations.competition_id = "WC2025"
AND competition_events.competition_id = "WC2025";

UPDATE competition_events SET qualification = null WHERE competition_id="WC2025";

UPDATE rounds
SET advancement_condition='{"type":"ranking","level":120}', total_number_of_rounds=3
WHERE competition_event_id IN (
  SELECT id
  FROM competition_events
  WHERE competition_id = "WC2025"
  AND event_id IN ("666", "777")
)
AND number = 1;

UPDATE rounds
SET advancement_condition='{"type":"ranking","level":16}', total_number_of_rounds=3
WHERE competition_event_id IN (
  SELECT id
  FROM competition_events
  WHERE competition_id = "WC2025"
  AND event_id IN ("666", "777")
)
AND number = 2;

INSERT INTO rounds (competition_event_id, format_id, number, time_limit, scramble_set_count, total_number_of_rounds, created_at, updated_at)
SELECT competition_events.id, "3", 3,
'{"centiseconds":24000,"cumulativeRoundIds":[]}', 1, "m", CURRENT_TIME(), CURRENT_TIME()
FROM competition_events
WHERE competition_id = "WC2025"
AND event_id IN ("666", "777");
