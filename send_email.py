import smtplib
import os

username = os.environ['USER_EMAIL']
password = os.environ['USER_PASSWORD']

sender = "Mytsum"
receiver = "Mytsum"

message = f"""\
Subject: GitHub Email Report
To: {receiver}
From: {sender}

This is your daily email report."""
try:
    with smtplib.SMTP("sandbox.smtp.mailtrap.io", 2525) as server:
        server.login(username, password)
        server.sendmail(sender, receiver, message)
    print("Email Sent...")
except:
    print("Error!")
