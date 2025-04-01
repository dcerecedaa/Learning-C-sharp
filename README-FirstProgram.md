# 💇♂️💈 Hair Salon Appointment System (First C# Project)

**Welcome to my first C# program!** A console-based booking system for hair salons, designed to manage appointments with specific times and personalized services.

---

## 🎯 **Key Features**
- **📅 Available Days**: From **Monday to Sunday** (options 1-7).
- **⏰ Predefined Schedules**: Each day has **8 unique time slots** (not generic).
*Example for Monday*:
`11:30, 12:00, 12:30, 13:00, 16:30, 17:30, 19:30, 20:00`
- **✂️ Fixed Price Services**:
- *Haircut*: €12.50
- *Haircut + beard*: €16.50
- *Beard only*: €4
- **🔄 Booking Loop**: You can make multiple bookings until you decide to leave.

---

## 🚀 **How ​​to Use**
1. **Launch the app**: Answer `yes` when asked if you want to come in.
2. **Choose a day**: Enter a number from 1 (Monday) to 7 (Sunday).
3. **Select a time**: Choose from the 8 options shown for that day.
4. **Choose your service**: Enter 'hair', 'hair and beard', or 'beard'.
5. **Confirm the price**: Done! Repeat the process or exit with 'no'.

---

## ⚙️ **Example Flow**
```plaintext
Do you want to log in to the app?
> yes

Enter your name:
> Ana

Choose a day (1-7):
> 1

Available hours for Monday:
1. 11:30 | 2. 12:00 | 3. 12:30 | ...
> 2

What service do you want? (hair/hair and beard/beard):
> hair and beard

The price is: €16.50

Another reservation? (yes/no):
> no
