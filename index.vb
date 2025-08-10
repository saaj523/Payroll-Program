# Payroll Program - CAT ONE
# Password Protected

# Step 1: Password Protection
PASSWORD = "admin123"

print("===== Payroll System =====")
user_pass = input("Enter system password: ")

if user_pass != PASSWORD:
    print("Access Denied. Wrong password!")
    exit()

# Step 2: Employee Details Input
emp_number = input("Enter Employee Number: ")
emp_name = input("Enter Employee Name: ")
gross_salary = float(input("Enter Gross Salary (Ksh): "))

# Step 3: Determine Income Tax
if gross_salary < 10000:
    income_tax = 0
elif gross_salary <= 49999:
    income_tax = 0.15 * gross_salary
elif gross_salary <= 99999:
    income_tax = 0.25 * gross_salary
else:
    income_tax = 0.30 * gross_salary

# Step 4: Determine House Levy & Medical Levy
if gross_salary < 10000:
    house_levy = 0
    medical_levy = 0
else:
    house_levy = 0.015 * gross_salary
    medical_levy = 0.015 * gross_salary

# Step 5: Calculate Net Salary
total_deductions = income_tax + house_levy + medical_levy
net_salary = gross_salary - total_deductions

# Step 6: Output Results
print("\n===== Payroll Slip =====")
print(f"Employee Number: {emp_number}")
print(f"Employee Name: {emp_name}")
print(f"Gross Salary: Ksh {gross_salary:,.2f}")
print(f"Income Tax: Ksh {income_tax:,.2f}")
print(f"House Levy: Ksh {house_levy:,.2f}")
print(f"Medical Levy: Ksh {medical_levy:,.2f}")
print(f"Total Deductions: Ksh {total_deductions:,.2f}")
print(f"Net Salary: Ksh {net_salary:,.2f}")
print("========================")
