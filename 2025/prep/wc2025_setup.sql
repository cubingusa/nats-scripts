-- Scripts for updating the database based on planned changes to WC2025.
--
-- docker exec -i database mysql wca_development < wc2025_setup.sql

DELETE FROM registration_competition_events
WHERE registration_id IN
(SELECT DISTINCT registrations.id
  FROM registrations
  JOIN users ON registrations.user_id = users.id
  JOIN ranks_average ON users.wca_id = ranks_average.person_id
  WHERE competition_id="WC2025"
  AND ranks_average.event_id = "333fm"
  AND ranks_average.best >= 2433)
AND competition_event_id IN
(SELECT DISTINCT id FROM competition_events WHERE competition_id="WC2025" AND event_id = "333fm");

DELETE FROM registration_competition_events
WHERE registration_id IN
(SELECT DISTINCT registrations.id
  FROM registrations
  JOIN users ON registrations.user_id = users.id
  JOIN ranks_single ON users.wca_id = ranks_single.person_id
  WHERE competition_id="WC2025"
  AND ranks_single.event_id = "333mbf"
  AND ranks_single.best >= 800349103)
AND competition_event_id IN
(SELECT DISTINCT id FROM competition_events WHERE competition_id="WC2025" AND event_id = "333mbf");

-- After running, use DEV_add_fake_results.cs to "open WCA Live" for round 1.
update rounds set round_results = null where competition_event_id in (select id from competition_events where competition_id = "WC2025");
