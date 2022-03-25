<template>
  <div class="tags">
    <q-title> Tags </q-title>
    <p class="tags__info">
      A tag is a keyword that allows you to describe the question exactly with
      your other similar relationships. By choosing the right labels, it is
      easier for other participants in the human body to find their question and
      answer it faster.
    </p>
    <div class="tags__tools">
      <search-input placeholder="Filter by name"/>
      <tabs-component :tabs="tabs" :active-tab="activeTab" @apply:tab="handleTabUpdate"/>
    </div>
    <div class="tags__content">
      <tag-block :tag="tag" class="tags__tag" v-for="i in 36" :key="i"/>
    </div>
    <div class="tags__pagination">
      <pagination-component :count="pagesCount" :current="curPage" @next="handleNext"/>
    </div>
  </div>
</template>

<script>
import QTitle from "@/components/QTitle";
import SearchInput from "@/components/SearchInput";
import TabsComponent from "@/components/Tabs";
import TagBlock from "@/components/TagBlock"
import PaginationComponent from "@/components/PaginationComponent"
export default {
  name: "Tags",
  components: {
    QTitle,
    SearchInput,
    TabsComponent,
    TagBlock,
    PaginationComponent
  },
};
</script>

<script setup>
import {ref} from "vue"
const tabs = ['Popular','Name','New']
const activeTab = ref(tabs[0]);
const pagesCount = ref(100);
const curPage = ref(1);
const tag = {
  title: 'javascript',
  count: 1000,
  info: "JavaScript (not to be confused with Java) is a loosely typed, dynamic, interpreted language commonly used for writing..."
}

const handleTabUpdate = (_tab) => {
  activeTab.value =_tab;
}
const handleNext = (_val) => {
  curPage.value = _val;
}
</script>

<style scoped lang="scss">
.tags {
  margin-left: 10px;
  &__info {
    color: var(--black900);
    max-width: 38.6153846rem;
    margin-bottom: 1rem;
  }
  &__tools {
    display: flex;
    justify-content: space-between;
    margin-bottom: 1rem;
    margin-right: 1rem;
  }
  &__content {
    display: flex;
    flex-wrap: wrap;
  }
  &__tag {
    margin-right: 1rem;
    margin-bottom: 1rem;
  }
  &__pagination {
    margin-right: 1rem;
    display: flex;
    justify-content:flex-end;
    margin-bottom: 1rem;
  }
}
</style>
