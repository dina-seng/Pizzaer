# Pizzaer — GitHub Guide (step by step)

Repo: **https://github.com/dina-seng/Pizzaer** (owner: Dina)

New words:
- **Git LFS** (Large File Storage) — keeps big files (models, images, sounds) outside normal Git, so the repo stays fast.
- **Branch** — your own copy of the code to work on, without breaking `main`.
- **Pull Request (PR)** — a request to merge your branch into `main`. Someone checks it first.
- **Merge conflict** — two people changed the same lines, and Git can't decide which to keep.

What the repo already has ✅: Unity `.gitignore`, a Unity `.gitattributes` (with LFS rules), and an empty Unity 6.3 URP project.
What is wrong ⚠️: Git LFS was **not on** when the first commit was made (1 PNG was saved as a normal file). Step 2 fixes this.

---

## Step 0 — Install tools (everyone)

1. **Unity Hub** → install Unity **6000.3.8f1** exactly (Installs → Install Editor → Archive if it is not listed). Add the **Windows Build Support** module.
2. **Git**: https://git-scm.com/downloads
3. **Git LFS**: https://git-lfs.com (on Windows it usually comes with Git, but check).
4. **GitHub Desktop** (easiest for beginners): https://desktop.github.com
5. Open a terminal (Git Bash or PowerShell) **once** and run:
   ```bash
   git lfs install
   git config --global user.name "Your Name"
   git config --global user.email "you@example.com"
   ```
   `git lfs install` must be done **on every computer**, or LFS files break.

## Step 1 — Get access and clone (everyone)

1. **Dina:** repo → **Settings → Collaborators → Add people** → add Viset, Panha, Soth (role: Write).
2. Everyone accepts the email invite.
3. GitHub Desktop → **File → Clone repository** → `dina-seng/Pizzaer` → choose a short path like `C:\Projects\Pizzaer` (no spaces or Khmer letters in the path).
4. Unity Hub → **Add → Add project from disk** → choose the `Pizzaer` folder → open with 6000.3.8f1.

## Step 2 — Fix Git LFS (Dina only, once, on Day 1)

In a terminal inside the repo folder:

```bash
git lfs install
git add --renormalize .
git commit -m "A1 Re-add files with Git LFS"
git push
```

Check: `git lfs ls-files` should list image/model files (if any are left after the template cleanup).
On GitHub, click a `.png` file — it should say **"Stored with Git LFS"**.

> 💡 GitHub's free plan has a limited LFS quota (storage and download bandwidth). Import **only the models you use**. Never commit whole zip packs or `Library/`.

## Step 3 — Unity settings for Git (Dina, once)

**Edit → Project Settings → Editor**:
- **Version Control → Mode:** `Visible Meta Files`
- **Asset Serialization → Mode:** `Force Text`

(Unity 6 already uses these by default. Just check.)

**Optional — Unity Smart Merge** (helps Git merge scenes and prefabs better). The `.gitattributes` file already asks for it. Each person can set it up once:

```bash
git config --global merge.unityyamlmerge.name "Unity SmartMerge"
git config --global merge.unityyamlmerge.driver "'C:/Program Files/Unity/Hub/Editor/6000.3.8f1/Editor/Data/Tools/UnityYAMLMerge.exe' merge -p %O %B %A %A"
git config --global merge.unityyamlmerge.recursive binary
```

Change the path if Unity is installed somewhere else. This is a **helper only**. Our real protection is the **ownership rule**.

## Step 4 — Protect `main` and add the PR template (Dina)

1. Repo → **Settings → Branches → Add branch protection rule** (or **Rules → Rulesets → New branch ruleset**).
2. Branch name pattern: `main`
3. Tick:
   - ✅ **Require a pull request before merging**
   - ✅ **Require approvals: 1**
   - ✅ **Do not allow bypassing** (optional — leave it off if Dina needs an emergency fix)
4. Save.
5. Commit the `docs/` folder and `.github/pull_request_template.md`. Now every new PR shows our checklist.

> Free GitHub accounts can protect branches on **public** repos. If the repo is private and the option is locked, just follow the rule "never push to main" by agreement.

**Who approves:** Dina approves and merges everyone's PRs. **Panha approves Dina's PRs.**

## Step 5 — Labels (Panha)

Repo → **Issues → Labels → New label**:

| Label | Color | Use |
|---|---|---|
| `epic` | #5319E7 | Parent issues |
| `setup` | #BFD4F2 | Project / GitHub setup |
| `town` | #0E8A16 | Map and environment |
| `player` | #FBCA04 | Player, zones, marker |
| `delivery` | #D93F0B | Delivery logic |
| `ui` | #1D76DB | Screens and HUD |
| `audio` | #C5DEF5 | Music and sound |
| `writing` | #F9D0C4 | Story and dialogue |
| `test` | #006B75 | Playtests, builds |
| `bug` | #B60205 | Something is broken |
| `nice-to-have` | #EDEDED | Only if there is time |
| `M2` | #7057FF | Milestone 2 work |
| `blocked` | #000000 | Waiting for something |

You can delete the default labels you don't need.

## Step 6 — Milestones (Panha)

Repo → **Issues → Milestones → New milestone**:
1. `M1 – Playable build` — due date **Nov 10, 2026** — description: "Full delivery loop playable in Unity, 5 deliveries, win screen."
2. `M2 – Timer & polish` — no due date.

## Step 7 — Project board (Panha)

1. Go to your profile or the repo → **Projects → New project → Board**. Name it `Pizzaer – M1`.
2. Columns (Status): `Backlog`, `Todo (this day)`, `In Progress`, `In Review`, `Done`.
3. Add a custom field: **⚙ → New field → "Day"** (Single select: `Day 1` … `Day 7`).
4. Link the project to the repo: repo → **Projects → Link a project**.
5. Board settings → **Workflows**: turn on "Item closed → Done" and "Pull request merged → Done".
6. Optional: add a **Table view** grouped by **Assignees**, so each person sees their list.

## Step 8 — Create epics and issues (Panha)

1. Create the **epics** first: `Epic A — Project setup`, `Epic B — Town map`, `Epic C — Player and interaction`, `Epic D — Delivery system`, `Epic E — UI, story, and sound`, `Epic G — Test and release`. Label: `epic`, Milestone: M1.
2. Open each epic → click **"Create sub-issue"** (or **Add sub-issue**) → create the issues from [PLAN.md](PLAN.md).
3. For each issue, fill in:
   - **Title:** `B2 · Town layout (block-out)`
   - **Body:** copy the Description + Acceptance criteria (as `- [ ]` checkboxes) + Owner + Day from PLAN.md
   - **Assignees:** the owner
   - **Labels**, **Milestone:** M1
   - **Project:** `Pizzaer – M1` → set **Day** and Status = `Backlog`
4. For A3 (everyone), assign all 4 people.

**Optional (faster): create issues with the GitHub CLI**

```bash
gh issue create --repo dina-seng/Pizzaer \
  --title "B2 · Town layout (block-out)" \
  --body-file issue_B2.md \
  --assignee DINA_GITHUB_USERNAME \
  --label town --milestone "M1 – Playable build" \
  --project "Pizzaer – M1"
```

(Replace the username. Link sub-issues to epics on the website afterwards.)

## Step 9 — Daily workflow (everyone)

```
Morning                        During the day                   Evening
───────                        ──────────────                   ───────
1. GitHub Desktop:             4. Work in YOUR files            7. Commit + Push
   Current branch = main          + YOUR Sandbox scene          8. Create Pull Request
   → Fetch → Pull              5. Ctrl+S + File → Save Project     (template + checklist)
2. Branch → New branch         6. Commit small steps            9. Move card → In Review
   feature/14-interact-zone       "#14 Add trigger check"      10. Dina merges before 9 PM
3. Move card → In Progress                                     11. Everyone pulls main
```

**In GitHub Desktop:**
- New branch: **Current branch → New branch** → name → **Create branch** (based on `main`).
- Get the newest `main` into your branch before the PR: **Branch → Update from main**.
- Commit: tick the files → write a summary like `#14 Add InteractZone trigger` → **Commit to feature/...**
- Push: **Push origin**. Then **Create Pull Request** (opens GitHub).

**On GitHub (PR page):**
- Title: `#14 InteractZone script + zone prefabs`
- Description: the template appears. Write `Closes #14` so the issue closes when merged.
- Tick the checklists. Add a screenshot or GIF.
- Reviewers: Dina (or Panha if you are Dina).
- Dina: **Squash and merge** → **Delete branch**.

## Step 10 — Rules to avoid Unity merge conflicts

1. **One owner per scene and prefab** (table in WORK_RULES.md §1.5). This is the most important rule.
2. **Only Dina edits `Town.unity`.** Everyone else tests in `Sandbox_<Name>.unity`.
3. **Prefabs instead of scene objects.** Build your thing as a prefab. Dina drops it into Town.
4. **Always commit the `.meta` file** together with its asset. GitHub Desktop shows both. Commit both.
5. **Never move or rename files outside Unity.**
6. **Don't change `ProjectSettings/` or `Packages/`** unless your issue says so. Importing an Asset Store pack changes `Packages/`, so do it in its own small PR, and merge it quickly.
7. **Pull every morning, PR every evening.** Old branches = big conflicts.
8. **"Lock" shared files in chat** before editing: `🔒 editing X` / `🔓 X done`.
9. **If a conflict happens in a `.unity` or `.prefab` file**: don't edit the text. In GitHub Desktop, choose **"Use the version from main"** (or "mine"), then redo your small change in Unity.
10. **Close Unity before switching branches** in GitHub Desktop. Unity sometimes keeps old files open.

## Step 11 — Final build and release (Dina, Day 7)

1. **File → Build Profiles** → choose **Windows** → check the scene list (`MainMenu`, `Town`) → **Build** → select the folder `Build/` (Git ignores it).
2. Zip the build folder and share it (Google Drive or Telegram). **Don't commit it.**
3. GitHub → **Releases → Draft a new release** → tag `v1.0` → title "Pizzaer M1 – Playable build" → attach the zip if it's under 2 GB.

---

### Quick help

| Problem | Fix |
|---|---|
| "This file is stored with LFS but LFS is not installed" | Run `git lfs install`, then in the repo `git lfs pull` |
| Push rejected: "protected branch" | Good — you tried to push to `main`. Make a branch and open a PR. |
| GitHub Desktop shows 1000s of changed files | You probably committed or changed `Library/`. Don't commit. Ask Dina. Check that `.gitignore` is in the root. |
| PR says "This branch has conflicts" | In GitHub Desktop: **Branch → Update from main** → resolve (see Step 10 rule 9) → push again |
