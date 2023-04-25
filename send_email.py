import smtplib
from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart
from email.mime.image import MIMEImage
from email.mime.base import MIMEBase
from email import encoders
import os

# Set up your Gmail credentials
username = os.environ.get('USER_EMAIL')
password = os.environ.get('USER_PASSWORD')

# Set up the email parameters
sender = username
recipient = username
subject = 'GitHub Email Report'
body = 'This is your daily email report.'

msg = MIMEMultipart()
msg['From'] = sender
msg['To'] = recipient
msg['Subject'] = subject

msg.attach(MIMEText(body, 'plain'))

# Create SMTP session and send email
server = smtplib.SMTP('smtp.office365.com', 587)
server.starttls()
server.login(username, password)
text = msg.as_string()
server.sendmail(sender, recipient, text)
server.quit()