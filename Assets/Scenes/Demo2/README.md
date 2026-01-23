# Bài 4: Demo2 - Basic Shooting
## Cấu trúc thư mục
- **Scene**: `Battle.unity` (nằm trong thư mục này)
- **Scripts** (nằm tại `Assets/Scrpit/Demo2/`):
  - `Bullet.cs`: Script điều khiển viên đạn bay lên theo trục Y với tốc độ `flySpeed`.
  - `PShooting.cs`: Script gắn vào người chơi, có nhiệm vụ sinh ra viên đạn (`bulletPrefabs`) sau mỗi khoảng thời gian `shootingInterval`.