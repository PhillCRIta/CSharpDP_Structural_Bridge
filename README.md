### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Bridge pattern
 The bridge design pattern decouple an abstraction from its implementation , to make possibile manage the two independently. \
 Make simplier managing the inheritance structure make its more adaptabile. \
 Prevent exponential growth of class hierarchy.
 Use also to refactor code get out of hand.

 The bridge separates a large class or a set of classes in two separate hierarchies.

**In our example 1: Get correct scuba diving equipments.** \
You must chose the correct SUIT for the correct ambient and temperture (dry suit threelayers, dry suit neoprene, wet suyt);
after that you must choose the accessories for the immersion, like regulator, jacket, cylinder and submarine computer.
 
**In example 2: Get correct remote to control the correct brand of home appliances.** \
The example separate the remote generic controller to the concrete brand of remote the bad case was LGRadioAndTVRemote, all together in the same remote.