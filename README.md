**#Unity Dive**

**_Collaborative VR for Environmental Awareness_**
This project is a collaborative, multi-user VR experience designed to raise awareness about water pollution through shared interaction.

Two users explore a synchronized underwater environment to locate and remove sunken debris. The experience culminates in a cooperative rescue mission to free a sea turtle trapped under trash, highlighting that environmental change requires collective action.

**_Technical Implementations_**
The core of this project was testing the limits of collaborative mechanics and networked physics. Key technical features include:

1. Networking and Synchronization: Built with Unity Netcode for GameObjects to synchronize complex physics and object states across clients in real time.

2. Locomotion Systems: Integrated steering, teleportation, and FOV reduction to ensure comfortable movement and mitigate motion sickness.

3. Interaction Mechanics: Implemented selection and manipulation techniques such as Ray Casting and the Go-Go technique for intuitive handling of distant objects.

4. Ownership Management: Utilized serialized manipulation access and ownership transfer to allow multiple users to interact with the same networked objects without desync or physics conflicts.

_**Hardware and Software**_
Engine: Unity 2022.3  
Networking: Netcode for GameObjects  
Hardware: Meta Quest 2 / Quest 3 via Link Cable or AirLink  
Toolkit: XR Interaction Toolkit
