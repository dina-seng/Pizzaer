# Pizzaer — Game Overview

> Team: **Dina** (level builder, integrator, merges), **Viset** (scripts), **Panha** (scripts, team lead), **Soth** (UI, art, sound, writing)
> Engine: **Unity 6.3 (6000.3.8f1)**, URP, PC
> Deadline: **Tue, Nov 10, 2026** — must be playable in Unity

---

## 1. The idea in one sentence

You are a new pizza delivery worker. **Walk** around a small town, pick up pizzas at the shop, and deliver them to the right houses.

It is a **delivery game with a small RPG flavour**: a short story, characters who talk to you, and money you earn.

## 2. Short story intro (draft — Soth writes the final text)

> "Grandpa Lim's pizza shop is finally open! But on the first day, the delivery boy quit.
> You are the only helper left. Deliver 5 pizzas around town and save the shop's big day!"

## 3. Core gameplay loop

This is what the player does again and again:

```
   ┌──────────────────────────────────────────────┐
   │                                              │
   ▼                                              │
[1] Go to the Pizza Shop                          │
   │  press E                                     │
   ▼                                              │
[2] Chef gives the order:                         │
    "Go to House #3 to deliver a Pepperoni pizza!"│
   │                                              │
   ▼                                              │
[3] Walk to House #3 (follow the glowing marker)  │
   │  press E                                     │
   ▼                                              │
[4] Customer says one line: "Thanks! Smells great!"
    Money +$10                                    │
   │                                              │
   └──── not finished? back to the shop ──────────┘
   │
   ▼ after 5 deliveries
[WIN] "Shop saved! You earned $60!"
```

- The player carries **only 1 pizza at a time**.
- A **target marker** (a glowing pillar) always shows where to go next: the shop or the right house.
- If the player goes to the **wrong house**, the person says, "Sorry, I didn't order pizza." Nothing bad happens.

## 4. Controls (PC)

| Key | Action |
|---|---|
| W A S D | Walk |
| Mouse | Look around (camera) |
| Left Shift | Run |
| Space | Jump |
| **E** | Talk / pick up pizza / deliver pizza (only inside a zone) |
| Mouse click | Buttons in menus |

## 5. Win and lose rules

| | Milestone 1 (this week) | Milestone 2 (after, if time) |
|---|---|---|
| **Win** | Deliver all 5 pizzas → Win screen with total money | Same |
| **Lose** | No lose rule | Timer runs out → Lose screen |

## 6. Screens

1. **Main Menu** — game title, Play, Quit
2. **Story panel** — short intro text, Start button
3. **Town (gameplay)** — HUD (heads-up display: info always on screen): money, current order, "Press E" prompt, dialogue box
4. **Win panel** — total money, Play Again, Main Menu

## 7. The 5 deliveries (example data — Soth writes the final text in `docs/STORY.md`)

| # | House | Pizza | Customer | Customer line | Reward |
|---|---|---|---|---|---|
| 1 | House #1 | Cheese | Mrs. Dara | "Just in time for lunch. Thank you!" | $10 |
| 2 | House #4 | Pepperoni | Mr. Sok | "It smells great! Here is your money." | $10 |
| 3 | House #2 | Hawaiian | Nita | "Pineapple on pizza is the best!" | $10 |
| 4 | House #5 | Veggie | Uncle Rith | "Fresh and hot. Good job, kid!" | $15 |
| 5 | House #3 | Seafood | Grandma Srey | "You saved the shop's first day!" | $15 |

Order of houses is mixed on purpose, so the player walks around the whole town.

## 8. Scope

### ✅ Must-have (Milestone 1 — "Playable build", due Nov 10)
- Small town map: roads, a roundabout, a park, buildings, signs, 1 pizza shop, 5 numbered houses
- Third-person character that walks, runs, and jumps (Unity Starter Assets)
- Trigger zones at the shop and houses with a "Press E" prompt
- Delivery system: 5 orders, one at a time, wrong-house message
- Target marker over the next place to go
- HUD: money, current order text, dialogue box (shop line + customer line)
- Main menu + short story intro
- Win screen with Play Again
- Background music + a few sound effects (pickup, deliver, button click, win)
- Works with no errors in the Unity Editor (and a Windows build if possible)

### 🟡 Nice-to-have (only if must-haves are done early)
- Customer characters standing at each house (Kenney Mini Characters)
- Pizza box model in the player's hands
- Parked cars, trees, and more decoration
- Footstep sounds and better lighting

### 🔵 Milestone 2 (after Milestone 1 is merged)
- Total timer (for example, 5 minutes) on the HUD
- Lose screen when the timer reaches 0
- Bonus money for fast deliveries
- Pause menu (Esc)

### ❌ Out of scope (we will NOT do these)
- Vehicles you can drive (car, scooter, bike)
- Traffic or walking NPC AI
- Dialogue with choices, quests, inventory, levelling up
- Save/load system
- Multiplayer, mobile version
- A big open city

**Why so small?** We are 4 beginners with 7 days. A small game that works is much better than a big game that is broken on demo day. If we finish early, we add nice-to-haves, one at a time.
