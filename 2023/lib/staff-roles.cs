Define(
    "CoreStaff",
    And(
      (StringProperty("staff-team-form") == "Core Staff (including Stage Leads)"),
      (NumberProperty("attending") > 2)
    )
)

Define(
    "Commentator",
    (StringProperty("staff-team-form") == "Live Stream Commentators")
)
