thisdir = class/System.Activities
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Activities.dll
LIB_REFS = 	System \
		System.Core \
		System.Runtime.DurableInstancing \
		System.Runtime.Serialization \
		System.ServiceModel.Internals \
		System.Transactions \
		Microsoft.CSharp \
		System.Xaml \
		System.Xml \
		System.Xml.Linq
LIB_MCS_FLAGS = /unsafe /res:System.Activities.SR.resources /res:System.Activities.TD.resources

ifeq (true, $(GENERATE_RESOURCES))
LIB_MCS_FLAGS += /define:GENERATING_RESOURCES
endif

RESX_RESOURCES = \
		System.Activities.SR.resources \
		System.Activities.TD.resources

CLEAN_FILES += $(RESX_RESOURCES)

RESOURCES = $(RESX_RESOURCES)

PREBUILT = $(RESX_RESOURCES:=.prebuilt)


TEST_MCS_FLAGS = $(LIB_MCS_FLAGS)

EXTRA_DISTFILES = more_build_args $(RESX_RESOURCES:.resources=.resx) $(PREBUILT)

include ../../build/library.make

$(the_lib): $(RESOURCES)

$(RESX_RESOURCES): %.resources: %.resx
	$(RESGEN) $< || cp $@.prebuilt $@

$(PREBUILT): %.prebuilt: %
	cp $* $@

dist-default: $(PREBUILT)

