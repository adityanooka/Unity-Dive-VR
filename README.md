#Unity Dive
Collaborative VR for Environmental Awareness
After several all-nighters and a few rogue computers in the lab, we completed Unity Dive at Bauhaus-Universität Weimar. This project is a collaborative, multi-user VR experience designed to raise awareness about water pollution through shared interaction.

Two users explore a synchronized underwater environment to locate and remove sunken debris. The experience culminates in a cooperative rescue mission to free a sea turtle trapped under trash, highlighting that environmental change requires collective action.

Technical Implementations
The core of this project was testing the limits of collaborative mechanics and networked physics. Key technical features include:

Networking and Synchronization: Built with Unity Netcode for GameObjects to synchronize complex physics and object states across clients in real time.

Locomotion Systems: Integrated steering, teleportation, and FOV reduction to ensure comfortable movement and mitigate motion sickness.

Interaction Mechanics: Implemented selection and manipulation techniques such as Ray Casting and the Go-Go technique for intuitive handling of distant objects.

Ownership Management: Utilized serialized manipulation access and ownership transfer to allow multiple users to interact with the same networked objects without desync or physics conflicts.

Hardware and Software
Engine: Unity 2022.3 (or your specific version)

Networking: Netcode for GameObjects

Hardware: Meta Quest 2 / Quest 3 via Link Cable or AirLink

Toolkit: XR Interaction Toolkit
