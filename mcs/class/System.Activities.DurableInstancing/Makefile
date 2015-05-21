thisdir = class/System.Activities.DurableInstancing
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Activities.DurableInstancing.dll
LIB_REFS = 	System \
		System.Core \
		System.Activities \
		System.Data \
		System.Runtime.DurableInstancing \
		System.Runtime.Serialization \
		System.ServiceModel.Internals \
		System.Transactions \
		System.Xml \
		System.Xml.Linq
LIB_MCS_FLAGS = /unsafe /res:System.Activities.DurableInstancing.SR.resources /res:System.Activities.DurableInstancing.TD.resources

ifeq (true, $(GENERATE_RESOURCES))
LIB_MCS_FLAGS += /define:GENERATING_RESOURCES
endif

RESX_RESOURCES = \
		System.Activities.DurableInstancing.SR.resources \
		System.Activities.DurableInstancing.TD.resources

CLEAN_FILES += $(RESX_RESOURCES)

RESOURCES = $(RESX_RESOURCES)

PREBUILT = $(RESX_RESOURCES:=.prebuilt)

TEST_MCS_FLAGS = $(LIB_MCS_FLAGS) 

EXTRA_DISTFILES = $(RESX_RESOURCES) $(PREBUILT)

include ../../build/library.make

$(the_lib): $(RESOURCES)

$(RESX_RESOURCES): %.resources: %.resx
	$(RESGEN) $< || cp $@.prebuilt $@

$(PREBUILT): %.prebuilt: %
	cp $* $@

dist-default: $(PREBUILT)
