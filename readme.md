# License
This project isn't supplied a license, in case I want to make it proprietary at one point.

# Dev note taking

## Feature ideas
Should probably be turned into the project board instead of a text file.
Draft:

### Core
 - Custom fields in a ticket
Things like customer data, items registration, sent text messages and so on.

 - Ticket assignment
There should be groups and/or users whom can be assigned to a ticket.

 - Prioritization system
I'm not really sure how it's best to implement this. I think I need to come up with an example of its use-case before I begin implementing it.

 - Ticket Tracking
Each ticket should have a unique identifier and a history of activities, making it easy to track its progress and changes.

 - Related tickets and ticket linking
It should be possible to somehow link tickets to each other.

### UI-API
The interface with which the UI communicates.

 - Creation of tickets
Custom fields should probably contain information describing (whether) and how they are filled when a ticket is created.
There should probably be custom behavior as well, in case the field data should be 'generated'/calculated from some information.

 - Locking API
It should be possible to lock fields in a ticket to a particular user.

### UI (in theory)
I don't plan on actually making a proper UI, but I want something to model the system after.

 - Custom tabs in tickets with custom logic
A plugin system should allow custom tabs, e.g. 'communication' for sending text messages and e-mail with customer (if customer even is defined at core-level), or a tab for generating PDFs based on the info in the ticket.

 - Communication and Collaboration
I'm not sure what this entails, but:
Support agents and users should be able to communicate and collaborate within the ticket/case system, through comments, attachments, and notifications.

 - Different ticket 'views'
Support agents should be able to create their own filters of tickets, and there could be some supplied beforehand aswell.

 - Custom labels and tree view
Put labels on tickets to sort them into categories and view them in a tree view.